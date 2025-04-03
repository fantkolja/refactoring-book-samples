using System.Web;

// base class for the pattern logic
abstract class HttpClientInterceptor
{
  private HttpClientInterceptor? _next;

  public HttpClientInterceptor SetNext(HttpClientInterceptor next)
  {
    this._next = next;
    return next;
  }
  protected string HandleNext(string requestUri, User user)
  {
    if (this._next == null)
    {
      return requestUri;
    }
    else
    {
      return this._next.Handle(requestUri, user);
    }
  }
  public abstract string Handle(string requestUri, User user);
}


//business-logic
class EmptyStringInterceptor : HttpClientInterceptor
{
  public override string Handle(string requestUri, User user)
  {
    if (String.IsNullOrWhiteSpace(requestUri))
    {
      throw new ArgumentException("URL cannot be empty");
    }
    return base.HandleNext(requestUri, user);
  }
}
class SchemeInterceptor : HttpClientInterceptor
{
  public override string Handle(string requestUri, User user)
  {
    Uri uri = new Uri(requestUri);
    if (uri.GetLeftPart(UriPartial.Scheme) != "https://")
    {
      throw new ArgumentException("Only HTTPS requests are allowed");
    }
    return base.HandleNext(requestUri, user);
  }
}
class QueryInterceptor : HttpClientInterceptor
{
  public override string Handle(string requestUri, User user)
  {
    string uriString = requestUri;
    Uri uri = new Uri(uriString);
    var uriQuery = HttpUtility.ParseQueryString(uri.Query);
    if (uriQuery.Get("role") == null)
    {
      uriQuery.Set("role", user.UserRole.ToString());
      uriString = uri.GetLeftPart(UriPartial.Path) + "?" + uriQuery;
    }
    return base.HandleNext(uriString, user);
  }
}

class UserRoleInterceptor : HttpClientInterceptor
{
  public override string Handle(string requestUri, User user)
  {
    if (user.UserRole != User.Role.Admin)
    {
      throw new AccessViolationException("Only Admins can make requests");
    }
    return base.HandleNext(requestUri, user);
  }
}

// usage
class SmartHttpClient
{
  private HttpClient _client = new HttpClient();

  private HttpClientInterceptor _getInterceptors()
  {
    var emptyStringInterceptor = new EmptyStringInterceptor();
    var schemeInterceptor = new SchemeInterceptor();
    var queryInterceptor = new QueryInterceptor();
    var userRoleinterceptor = new UserRoleInterceptor();
    
    emptyStringInterceptor
      .SetNext(schemeInterceptor)
      .SetNext(queryInterceptor)
      .SetNext(userRoleinterceptor);

    return emptyStringInterceptor;
  }
  public Task<string> Fetch(string requestUri, User user)
  {
    var interceptors = _getInterceptors();

    string uriString = interceptors.Handle(requestUri, user);
  
    Console.WriteLine("Sending a GET request to " + uriString);
    return _client.GetStringAsync(uriString);
  }
}