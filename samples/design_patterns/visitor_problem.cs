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


// polymorphism breaks a lot of principles (SRP, OCP)












// it's not convenient to iterate with such class
class ExciseCalculator
{
  public double GetExciseForAlcohol(Alcohol alcohol) => alcohol.Price * 3;
  public double GetExciseForTobacco(Tobacco tobacco) => tobacco.Price * 5;
  public double GetExciseForMilk(MilkProduct milk) => milk.Price * 0.5;
}

var calc = new ExciseCalculator();

List<Ware> wares = new List<Ware>
{
  new Alcohol("vodyara", 2, 40),
  new Alcohol("whiskey", 3, 50),
  new MilkProduct("Yahotyn", 1, 15)
};

wares.ForEach(ware =>
{
  if (ware is Alcohol)
  {
    calc.GetExciseForAlcohol(ware as Alcohol);
  }
  // ...
});