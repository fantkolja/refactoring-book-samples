class Hero
{
  private List<Artefact> _artefacts = new List<Artefact>();
  public string Name { get; private set; }

  private int _power;

  public Hero(string name, int power)
  {
    this.Name = name;
    this._power = power;
  }

  public void AddArtefact(Artefact artefact)
  {
    this._artefacts.Add(artefact);
  }

  public void RemoveArtefact(Artefact artefact)
  {
    this._artefacts.Remove(artefact);
  }

  public void Strike()
  {
    int totalPower = this._artefacts.Aggregate(this._power, (sum, next) => sum += next.GetPowerBuf());
    Console.WriteLine($"{this.Name} hits with power {totalPower}");
  }

  public void CalculateArtefactsWeight()
  {
    int totalArtefactsWeight = this._artefacts.Aggregate(0, (sum, next) => sum += next.GetWeight());
    Console.WriteLine($"Total artefacts weight: {totalArtefactsWeight}");
  }

  public void CountArtefacts()
  {
    int totalArtefactCount = this._artefacts.Count;
    Console.WriteLine($"{this.Name} has {totalArtefactCount} artefacts");
  }
}

class Artefact
{
  public string Name { get; protected set; }
  protected int _weight;
  protected int _powerBuf;

  public Artefact(string name, int weight, int powerBuf)
  {
    this.Name = name;
    this._weight = weight;
    this._powerBuf = powerBuf;
  }

  public virtual int GetWeight()
  {
    return this._weight;
  }

  public virtual int GetPowerBuf()
  {
    return this._powerBuf;
  }

  public virtual int GetCount()
  {
    return 1;
  }
}

var gloveOfPower = new ArtefactWithArtefacts("Glove Of Power", 500, 1000);

var mindGem = new Artefact("Mind Gem", 50, 500);
var powerGem = new Artefact("Power Gem", 10, 100);
var soulGem = new Artefact("Soul Gem", 10, 100);

gloveOfPower.AddArtefact(mindGem);
gloveOfPower.AddArtefact(powerGem);
gloveOfPower.AddArtefact(soulGem);