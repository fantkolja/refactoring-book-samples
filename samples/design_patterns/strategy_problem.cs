class Order
{
  public double Weight { get; set; }
}
class ShippingCostCalculator
{
  public double CalculateCost(Order order, string shippingMethod)
  {
    if (shippingMethod == "standard")
    {
      return order.Weight * 5;
    }
    else if (shippingMethod == "express")
    {
      return order.Weight * 10;
    }
    else if (shippingMethod == "pickup")
    {
      return 0;
    }
    else
    {
      throw new ArgumentException("Invalid shipping method");
    }
  }
}
