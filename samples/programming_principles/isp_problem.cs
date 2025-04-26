interface IMFD
{
  void Print(string content);
  void Scan(string content);
  void Copy(string content);
}

class MFD : IMFD
{
  public void Print(string content)
  {
    Console.WriteLine($"Printing {content}");
  }

  public void Scan(string content)
  {
    Console.WriteLine($"Scanning {content}");
  }

  public void Copy(string content)
  {
    Console.WriteLine($"Copying {content}");
  }
}



// solution
interface IPrinter
{
  void Print(string content);
}

interface IScanner
{
  void Scan(string content);
}

interface ICopier
{
  void Copy(string content);
}

class MFD : IPrinter, IScanner, ICopier
{
  public void Print(string content)
  {
    Console.WriteLine($"Printing {content}");
  }

  public void Scan(string content)
  {
    Console.WriteLine($"Scanning {content}");
  }

  public void Copy(string content)
  {
    Console.WriteLine($"Copying {content}");
  }
}

class CanonPrinter : IPrinter
{
  public void Print(string content)
  {
    Console.WriteLine($"Canon printing {content}");
  }
}

class XeroxPrinterScanner : IPrinter, IScanner
{
  public void Print(string content)
  {
    Console.WriteLine($"Xerox printing {content}");
  }

  public void Scan(string content)
  {
    Console.WriteLine($"Xerox scanning {content}");
  }
}
