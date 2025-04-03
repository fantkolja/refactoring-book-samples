using System.Web;

class SmartHttpClient
{
  private HttpClient _client = new HttpClient();
  public Task<string> Fetch(string requestUri, User user)
  {
    string uriString = requestUri;
    if (String.IsNullOrWhiteSpace(requestUri))
    {
      throw new ArgumentException("URL cannot be empty");
    }
    Uri uri = new Uri(uriString);
    if (uri.GetLeftPart(UriPartial.Scheme) != "https://")
    {
      throw new ArgumentException("Only HTTPS requests are allowed");
    }
    
    var uriQuery = HttpUtility.ParseQueryString(uri.Query);
    if (uriQuery.Get("role") == null)
    {
      uriQuery.Set("role", user.UserRole.ToString());
      uriString = uri.GetLeftPart(UriPartial.Path) + "?" + uriQuery;
    }
    if (user.UserRole != User.Role.Admin)
    {
      throw new AccessViolationException("Only Admins can make requests");
    }
    
    Console.WriteLine("Sending a GET request to " + uriString);
    return _client.GetStringAsync(uriString);
  }
}