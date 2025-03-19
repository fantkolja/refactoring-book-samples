interface IImage
{
  void Display();
}

class RealImage : IImage
{
  private string _filePath;

  public RealImage(string filePath)
  {
    _filePath = filePath;
    LoadFromDisk();
  }

  private void LoadFromDisk()
  {
    Console.WriteLine($"Loading image from {_filePath}");
  }

  public void Display()
  {
    Console.WriteLine($"Displaying {_filePath}");
  }
}

class VirtualProxyImage : IImage
{
  private string _filePath;
  private RealImage _realImage;

  public VirtualProxyImage(string filePath)
  {
    _filePath = filePath;
  }

  public void Display()
  {
    if (_realImage == null)
    {
      _realImage = new RealImage(_filePath);
    }
    _realImage.Display();
  }
}
