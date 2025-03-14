abstract class CoffeeExtra : Coffee
{
  private Coffee _coffee;
  public override int Amount
  {
    get { return this._coffee.Amount; }
    set { this._coffee.Amount = value; }
  }
  public override int Price
  {
    get { return this._coffee.Price; }
    set { this._coffee.Price = value; }
  }
  public CoffeeExtra(Coffee coffee) : base()
  {
    this._coffee = coffee;
  }

  public override double GetCalories()
  {
    return this._coffee.GetCalories();
  }
}

class WithMilk : CoffeeExtra
{
  public WithMilk(Coffee coffee) : base(coffee)
  {
    base.Amount += 3;
    base.Price += 5;
  }

  public override double GetCalories()
  {
    return base.GetCalories() * 100;
  }
}

class Doubled : CoffeeExtra
{
  public Doubled(Coffee coffee) : base(coffee)
  {
    base.Amount *= 2;
    base.Price += 10;
  }

  public override double GetCalories()
  {
    return base.GetCalories() * 2;
  }
}

class WithSugar : CoffeeExtra
{
  private int _sticksCount;
  public WithSugar(Coffee coffee, int sticksCount) : base(coffee)
  {
    this._sticksCount = sticksCount;
    base.Amount += sticksCount * 1;
  }

  public override double GetCalories()
  {
    return base.GetCalories() + this._sticksCount * 100;
  }
}

Coffee doubledEspressoWithMilk = new Doubled(new WithMilk(new Espresso()));
Coffee americanoWithTwoSugar = new WithSugar(new Americano(), 2);