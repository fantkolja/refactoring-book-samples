public class DiscountCalculator
{
  public double CalculateDiscount(string customerType, double total)
  {
    if (customerType == "Regular")
    {
      return total * 0.1;
    }
    else if (customerType == "VIP")
    {
      return total * 0.2;
    }
    else
    {
      return 0;
    }
  }
}
