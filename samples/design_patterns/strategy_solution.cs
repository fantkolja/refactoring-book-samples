interface IShippingStrategy
{
  double CalculateCost(Order order);
}

class StandardShipping : IShippingStrategy
{
  public double CalculateCost(Order order)
  {
    return order.Weight * 5;
  }
}

class ExpressShipping : IShippingStrategy
{
  public double CalculateCost(Order order)
  {
    return order.Weight * 10;
  }
}

class PickupShipping : IShippingStrategy
{
  public double CalculateCost(Order order)
  {
    return 0;
  }
}

class ShippingCostCalculator
{
  private IShippingStrategy _strategy;

  public ShippingCostCalculator(IShippingStrategy strategy)
  {
    _strategy = strategy;
  }

  public void SetStrategy(IShippingStrategy strategy)
  {
    _strategy = strategy;
  }

  public double Calculate(Order order)
  {
    return _strategy.CalculateCost(order);
  }
}

class Program
{
  static void Main()
  {
    var order = new Order { Weight = 10 };

    var calculator = new ShippingCostCalculator(new StandardShipping());
    Console.WriteLine("Standard: " + calculator.Calculate(order));

    calculator.SetStrategy(new ExpressShipping());
    Console.WriteLine("Express: " + calculator.Calculate(order));

    calculator.SetStrategy(new PickupShipping());
    Console.WriteLine("Pickup: " + calculator.Calculate(order));
  }
}
