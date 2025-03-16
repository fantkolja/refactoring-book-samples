class Pizza
{
  private string _cheese;
  private string _meat;
  private bool _corn;
  private string _olives;
  private int? _radius;
  private int? _thickness;

  public Pizza(string cheese, string meat, bool corn, string olives, int radius, int thickness)
  {
    _cheese = cheese;
    _meat = meat;
    _corn = corn;
    _olives = olives;
    _radius = radius;
    _thickness = thickness;
  }
}

new Pizza("bree", "salami", true, "green", 40, 5);