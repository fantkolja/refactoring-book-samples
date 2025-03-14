interface IFactory
{
  public IProductA CreateConcreteProductA();
  public IProductB CreateConcreteProductB();
}

class ConcreteFactory1 : IFactory
{
  public IProductA CreateConcreteProductA()
  {
    return new ConcreteProductA1("A");
  }

  public IProductB CreateConcreteProductB()
  {
    return new ConcreteProductB1(1);
  }
}

class ConcreteFactory2 : IFactory
{
  public IProductA CreateConcreteProductA()
  {
    return new ConcreteProductA2("A");
  }

  public IProductB CreateConcreteProductB()
  {
    return new ConcreteProductB2(2);
  }
}

interface IProductA
{
  public string Name { get; }
}

interface IProductB
{
  public int Weight { get; }
}

class ConcreteProductA1 : IProductA
{
  public string Name { get; private set; }

  public ConcreteProductA1(string name)
  {
    this.Name = name;
  }
}

class ConcreteProductA2 : IProductA
{
  public string Name { get; private set; }

  public ConcreteProductA2(string name)
  {
    this.Name = name;
  }
}

class ConcreteProductB1 : IProductB
{
  public int Weight { get; private set; }

  public ConcreteProductB1(int weight)
  {
    this.Weight = weight;
  }
}

class ConcreteProductB2 : IProductB
{
  public int Weight { get; private set; }

  public ConcreteProductB2(int weight)
  {
    this.Weight = weight;
  }
}