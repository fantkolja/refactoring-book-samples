class Pizza
{
  private string _cheese = "No cheese";
  private string _meat = "No meat";
  private bool _corn = false;
  private string _olives = "No olives";
  private int? _radius;
  private int? _thickness;

  // +10 more

  public Pizza() {}
  public string SetCheese(string cheese)
  {
    return this._cheese = cheese;
  }
  public string SetMeat(string meat)
  {
    return this._meat = meat;
  }
  public bool SetCorn()
  {
    return this._corn = true;
  }
  public string SetOlives(string olives)
  {
    return this._olives = olives;
  }
  public int SetRadius(int radius)
  {
    this._radius = radius;
    return radius;
  }
  public int SetThickness(int thickness)
  {
    this._thickness = thickness;
    return thickness;
  }
}

interface IPizzaBuilder
{
  Pizza GetPizza();
  IPizzaBuilder SetRadius(int radius);
  IPizzaBuilder AddCheese(string cheese);
  IPizzaBuilder AddMeat(string meat);
  IPizzaBuilder AddCorn();
  IPizzaBuilder AddOlives(string olives);
}

class HousePizzaBuilder : IPizzaBuilder
{
  private Pizza _pizza = new Pizza();
  private void _reset()
  {
    this._pizza = new Pizza();
    this._pizza.SetThickness(5);
  }

  public HousePizzaBuilder()
  {
    this._reset();
  }

  public IPizzaBuilder AddCheese(string cheese)
  {
    this._pizza.SetCheese(cheese);
    return this;
  }

  public IPizzaBuilder AddCorn()
  {
    this._pizza.SetCorn();
    return this;
  }

  public IPizzaBuilder AddMeat(string meat)
  {
    this._pizza.SetMeat(meat);
    return this;
  }

  public IPizzaBuilder AddOlives(string olives)
  {
    this._pizza.SetOlives(olives);
    return this;
  }

  public Pizza GetPizza()
  {
    Pizza pizza = this._pizza;
    this._reset();
    return pizza;
  }

  public IPizzaBuilder SetRadius(int radius)
  {
    this._pizza.SetRadius(radius);
    return this;
  }
}

class PizzaDirector
{
  private IPizzaBuilder _builder;

  public PizzaDirector SetBuilder(IPizzaBuilder builder)
  {
    this._builder = builder;
    return this;
  }

  public PizzaDirector(IPizzaBuilder builder)
  {
    this._builder = builder;
  }

  public Pizza GetNeapolitanaPizza()
  {
    return this._builder
      .SetRadius(45)
      .AddCheese("Mascarpone")
      .AddCorn()
      .AddMeat("Chicken")
      .GetPizza();
  } 

  public Pizza GetDrivePizza()
  {
    return this._builder
      .SetRadius(50)
      .AddCheese("Bree")
      .AddCorn()
      .AddOlives("Green")
      .GetPizza();
  } 
}