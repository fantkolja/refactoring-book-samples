abstract class Ware
{
  public string Name { get; set; }
  public int Price { get; set; }
  public Ware(string name, int price)
  {
    this.Name = name;
    this.Price = price;
  }
}

class Alcohol : Ware
{
  public double Strength;
  public Alcohol(string name, int price, double strength) : base(name, price)
  {
    this.Strength = strength;
  }
  public override string ToString()
  {
    return $"Alcohol drink: {this.Name}";
  }
}

class MilkProduct : Ware { /* ... */ }
class Tobacco : Ware { /* ... */ }





interface IWareVisitor
{
  public double Visit(Alcohol ware);
  public double Visit(Tobacco ware);
  public double Visit(MilkProduct ware);
}

class ExciseVisitor : IWareVisitor
{
  public double Visit(Alcohol ware) => ware.Price * 1.4;
  public double Visit(Tobacco ware) => ware.Price * 1.2;
  public double Visit(MilkProduct ware) => ware.Price * 1;
}

class WarTimeExciseVisitor : IWareVisitor
{
  public double Visit(Alcohol ware) => ware.Price * 3;
  public double Visit(Tobacco ware) => ware.Price * 1.1;
  public double Visit(MilkProduct ware) => ware.Price * 1;
}



// with the native double dispatch
var visitor = new ExciseVisitor();

List<Ware> wares = new List<Ware>
{
  new Alcohol("vodyara", 1, 40),
  new Alcohol("whiskey", 1, 50),
  new MilkProduct("Yahotyn", 1, 15)
};

wares.ForEach(ware => visitor.Visit(ware));








// with "manual" double dispatch
interface IVisitableWare
{
  public double Accept(IWareVisitor visitor);
}
class Alcohol : Ware, IVisitableWare
{
  // ...
  public double Accept(IWareVisitor visitor)
  {
    return visitor.Visit(this);
  }
}

var visitor = new ExciseVisitor();

List<Ware> wares= new List<Ware>
{
  new Alcohol("vodyara", 1, 40),
  new Alcohol("whiskey", 1, 50),
  new MilkProduct("Yahotyn", 1, 15)
};

wares.ForEach(ware => ware.Accept(visitor));