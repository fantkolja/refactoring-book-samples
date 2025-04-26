public interface IBird
{
  public void Walk();
  public void Fly();
}

public class Parrot : IBird
{
  public void Walk()
  {
    Console.WriteLine("Walking");
  }
  public void Fly()
  {
    Console.WriteLine("Flying");
  }
}

public class Penguin : IBird
{
  public void Walk()
  {
    Console.WriteLine("Walking");
  }
  public void Fly()
  {
    throw new NotImplementedException(); // Порушення LSP!
  }
}

public void MakeBirdFly(IBird bird)
{
  bird.Fly();
}
if (bird is Penguin)
{
  // Не намагайся літати
}
else
{
  bird.Fly();
}
