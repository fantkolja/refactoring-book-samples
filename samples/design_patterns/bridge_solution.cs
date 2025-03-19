interface ITransportationKind
{
  public void ChangePlace(int speed);
}

class AirTransportation : ITransportationKind
{
  public void ChangePlace(int speed)
  {
    Console.WriteLine($"Moving by air with speed {speed * 3}");
  }
}

  class LandTransportation : ITransportationKind
  {
    public void ChangePlace(int speed)
    {
      Console.WriteLine($"Moving by land with speed {speed}");
    }
  }

abstract class Transport
{
  protected ITransportationKind _transportationKind;
  public int Speed { get; set; } = 1;
  public string Name { get; set; }

  public Transport(string name, ITransportationKind transportationKind)
  {
    this._transportationKind = transportationKind;
    this.Name = name;
  }
  public abstract void Move();
}
class MobTransport : Transport
{
  public MobTransport(string name, int speed, ITransportationKind transportationKind) : base(name, transportationKind)
  {
    this.Speed = speed;
  }

  public override void Move()
  {
    _transportationKind.ChangePlace(this.Speed);
  }
}
class HeroTransport : Transport
{
  public int Capacity { get; set; } = 1;

  public HeroTransport(string name, int speed, int capacity, ITransportationKind transportationKind) : base(name, transportationKind)
  {
    this.Speed = speed;
    this.Capacity = capacity;
  }

  public override void Move()
  {
    _transportationKind.ChangePlace(this.Speed);
  }
}

var airTransportation = new AirTransportation();
var landTransportation = new LandTransportation();

var horse = new HeroTransport("Horse", 3, 2, airTransportation);
var lizard = new MobTransport("lizard", 2, landTransportation);

horse.Move();
lizard.Move();