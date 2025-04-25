public interface IDiscountStrategy
{
  double Calculate(double total);
}

public class RegularDiscount : IDiscountStrategy
{
  public double Calculate(double total) => total * 0.1;
}

public class VIPDiscount : IDiscountStrategy
{
  public double Calculate(double total) => total * 0.2;
}

public class PremiumDiscount : IDiscountStrategy
{
  public double Calculate(double total) => total * 0.3;
}

public class DiscountCalculator
{
  private readonly IDiscountStrategy _strategy;

  public DiscountCalculator(IDiscountStrategy strategy)
  {
    _strategy = strategy;
  }

  public double CalculateDiscount(double total) => _strategy.Calculate(total);
}
