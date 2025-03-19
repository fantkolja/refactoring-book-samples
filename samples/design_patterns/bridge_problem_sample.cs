abstract class Transport
{
  public int Speed { get; set; } = 1;
  public string Name { get; set; }

  public Transport(string name)
  {
    this.Name = name;
  }

  public abstract void Move();
}

class HeroTransport : Transport
{
  public int Capacity { get; set; } = 1;

  public HeroTransport(string name, int speed, int capacity) : base(name)
  {
    this.Speed = speed;
    this.Capacity = capacity;
  }

  public override void Move()
  {
    Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed} carrying {this.Capacity} heroes");
  }
}

class MobTransport : Transport
{
  public MobTransport(string name, int speed) : base(name)
  {
    this.Speed = speed;
  }

  public override void Move()
  {
    Console.WriteLine($"Moving on the {this.Name} with the speed {this.Speed}");
  }
}