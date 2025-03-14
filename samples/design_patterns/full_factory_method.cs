public interface IProduct
{
  string GetName();
}

class ConcreteProductA : IProduct
{
  private string _name;

  public ConcreteProductA(string name)
  {
    this._name = name;
  }

  public string GetName()
  {
    return $"This is Product A with the name {this._name}";
  }
}

class ConcreteProductB : IProduct
{
  private string _model;

  public ConcreteProductB(string model)
  {
    this._model = model;
  }

  public string GetName()
  {
    return $"This is Product B with the model {this._model}";
  }
}

interface ICreator
{
  public IProduct CreateProduct(string name, int year);
}

class ConcreteCreatorX : ICreator
{
  public IProduct CreateProduct(string name, int year) {
    IProduct product;
    if (year < 2001) {
      product = new ConcreteProductA(name);
    } else {
      product = new ConcreteProductB(name);
    }
    return product;
  }
}

class ConcreteCreatorY : ICreator
{
  public IProduct CreateProduct(string name, int year) {
    IProduct product;
    if (year < 2011) {
      product = new ConcreteProductA(name);
    } else {
      product = new ConcreteProductB(name);
    }
    return product;
  }
}