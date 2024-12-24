namespace DesignPatterns.FactoryMethod
{
  public interface IClassicProduct
  {
    string GetName();
  }

  class ConcreteProductA : IClassicProduct
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

  class ConcreteProductB : IClassicProduct
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

  // can also be an abstract class
  interface IClassicFactoryMethodCreator
  {
    public IClassicProduct CreateProduct(string name, int year);
  }
  
  class ClassicFactoryMethodCreatorX : IClassicFactoryMethodCreator
  {
    public IClassicProduct CreateProduct(string name, int year) {
      IClassicProduct product;
      if (year < 2001) {
        product = new ConcreteProductA(name);
      } else {
        product = new ConcreteProductB(name);
      }
      return product;
    }
  }

  class ClassicFactoryMethodCreatorY : IClassicFactoryMethodCreator
  {
    public IClassicProduct CreateProduct(string name, int year) {
      IClassicProduct product;
      if (year < 2011) {
        product = new ConcreteProductA(name);
      } else {
        product = new ConcreteProductB(name);
      }
      return product;
    }
  }
}