namespace DesignPatterns.Prototype
{
  interface ICloneable
  {
    ICloneable Clone();
  }
  class Prototype : ICloneable
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
    public virtual ICloneable Clone()
    {
      return new Prototype(this);
    }
  }
}
