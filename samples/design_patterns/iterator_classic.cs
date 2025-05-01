interface IClassicIterator<T>
{
  bool MoveNext();
  T? Current { get; }
  void Reset();
}

class AlphabeticalIterator : IClassicIterator<string>
{
  private ConcreteAggregate _aggregate;
  private List<PropertyInfo> _aggregateProperties
  {
    get
    {
      List<PropertyInfo> propList = this._aggregate.GetType().GetProperties().ToList();
      propList.Sort((PropertyInfo prop1, PropertyInfo prop2) => String.Compare(prop1.Name, prop2.Name, StringComparison.Ordinal));
      return propList;
    }
  }
  private int _cursor = -1;
  public AlphabeticalIterator(ConcreteAggregate aggregate)
  {
    this._aggregate = aggregate;
  }
  public string? Current => (string?)_aggregateProperties[_cursor].GetValue(_aggregate);
  public bool MoveNext()
  {
    _cursor++;
    return _cursor < _aggregateProperties.Count;
  }
  public void Reset()
  {
    this._cursor = -1;
  }
}

interface IClassicAggregate<T>
{
  public IClassicIterator<T> GetIterator();
}

class ConcreteAggregate : IClassicAggregate<string>
{
  public string X { get; set; } = "x";
  public string Fak { get; set; } = "fak";
  public string F { get; set; } = "f";
  public string A { get; set; } = "a";
  public string B { get; set; } = "b";
  public string C { get; set; } = "c";

  public IClassicIterator<string> GetIterator()
  {
    return new AlphabeticalIterator(this);
  }
}

var aggregate = new ConcreteAggregate();
logEach(aggregate);

static void logEach(IClassicAggregate<string> aggregate)
{
  var iterator = aggregate.GetIterator();
  while (iterator.MoveNext())
  {
    Console.WriteLine(iterator.Current);
  }
  iterator.Reset();
}






// with yield
class ConcreteAggregate
{
  public string X { get; set; } = "x";
  public string Fak { get; set; } = "fak";
  public string F { get; set; } = "f";
  public string A { get; set; } = "a";
  public string B { get; set; } = "b";
  public string C { get; set; } = "c";

  public IEnumerable<string> IterateAlphabetically()
  {
    yield return this.A;
    yield return this.B;
    yield return this.C;
    yield return this.F;
    yield return this.Fak;
    yield return this.X;
  }
}

// використання
var aggregate = new ConcreteAggregate();

foreach (var item in aggregate.IterateAlphabetically())
{
    Console.WriteLine(item);
}








// with async yield
// public async IAsyncEnumerable<string> GetProps()
// {
//   yield return this.A;
//   yield return this.B;
//   await Task.Delay(3000);
//   yield return this.C;
//   yield return this.F;
//   yield return this.Fak;
//   yield return this.X;
// }