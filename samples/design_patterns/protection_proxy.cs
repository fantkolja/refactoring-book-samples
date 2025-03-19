interface IServerSettings
{
  void Configure();
}

class RealServerSettings : IServerSettings
{
  public void Configure()
  {
    Console.WriteLine("Configuring server...");
  }
}

class ProtectionProxy : IServerSettings
{
  private RealServerSettings _realServerSettings;
  private string _userRole;

  public ProtectionProxy(string userRole)
  {
    _realServerSettings = new RealServerSettings();
    _userRole = userRole;
  }

  public void Configure()
  {
    if (_userRole == "Admin")
    {
      _realServerSettings.Configure();
    }
    else
    {
      Console.WriteLine("Access denied: insufficient permissions.");
    }
  }
}
