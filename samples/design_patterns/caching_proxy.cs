interface IDataService
{
  string GetData();
}

class RealDataService : IDataService
{
  public string GetData()
  {
    Console.WriteLine("Fetching data from database...");
    return "Database Result";
  }
}

class CachingProxy : IDataService
{
  private RealDataService _realDataService;
  private string _cachedData;

  public CachingProxy()
  {
    _realDataService = new RealDataService();
  }

  public string GetData()
  {
    if (_cachedData == null)
    {
      _cachedData = _realDataService.GetData();
    }
    else
    {
      Console.WriteLine("Returning cached data.");
    }
    return _cachedData;
  }
}
