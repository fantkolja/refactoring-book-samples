public interface ICommand
{
  void Execute();
  void Undo();
}

// Receiver
public class Light
{
  public void On()
  {
    Console.WriteLine("Світло увімкнено");
  }

  public void Off()
  {
    Console.WriteLine("Світло вимкнено");
  }
}

// concrete commands
public class LightOnCommand : ICommand
{
  private readonly Light _light;

  public LightOnCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.On();
  }

  public void Undo()
  {
    _light.Off();
  }
}

public class LightOffCommand : ICommand
{
  private readonly Light _light;

  public LightOffCommand(Light light)
  {
    _light = light;
  }

  public void Execute()
  {
    _light.Off();
  }

  public void Undo()
  {
    _light.On();
  }
}

// Invoker
public class RemoteControl
{
  private ICommand _command;

  public void SetCommand(ICommand command)
  {
    _command = command;
  }

  public void PressButton()
  {
    _command.Execute();
  }

  public void PressUndo()
  {
    _command.Undo();
  }
}

// client
class Program
{
  static void Main()
  {
    Light livingRoomLight = new Light();
    ICommand lightOn = new LightOnCommand(livingRoomLight);
    ICommand lightOff = new LightOffCommand(livingRoomLight);

    RemoteControl remote = new RemoteControl();

    remote.SetCommand(lightOn);
    remote.PressButton();   // Світло увімкнено
    remote.PressUndo();     // Світло вимкнено

    remote.SetCommand(lightOff);
    remote.PressButton();   // Світло вимкнено
    remote.PressUndo();     // Світло увімкнено
  }
}

// history stack
Stack<ICommand> history = new Stack<ICommand>();
history.Push(lightOn);
history.Peek().Undo();

