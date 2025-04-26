public class Rectangle
{
  public virtual int Width { get; set; }
  public virtual int Height { get; set; }

  public int Area()
  {
    return Width * Height;
  }
}

public class Square : Rectangle
{
  public override int Width
  {
    set
    {
      base.Width = value;
      base.Height = value;
    }
  }

  public override int Height
  {
    set
    {
      base.Width = value;
      base.Height = value;
    }
  }
}



Rectangle rect = new Square();
rect.Width = 5;
rect.Height = 10;
Console.WriteLine(rect.Area()); // Очікуємо 50, але отримаємо 100!
