namespace DesignPatterns.Prototype
{
  interface IClonable
  {
    IClonable Clone();
  }
  class Prototype : IClonable
  {
    private string _name;
    public Prototype(string name)
    {
      this._name = name;
    }
    public Prototype(Prototype prototype)
    {
      this._name = prototype._name;
    }
    public virtual IClonable Clone()
    {
      return new Prototype(this);
    }
  }
}
