interface IEventListener
{
  public void OnSubmit();
}

class LoginForm : IEventListener
{
  public List<Input> Inputs = new List<Input>();
  public SubmitButton Button = new SubmitButton();

  public void OnSubmit()
  {
    ValidateInputs();
  }

  public void ValidateInputs() { }
}

class Tooltip : IEventListener
{
  public SubmitButton WrappedButton { set; get; }
  public string Text { set; get; }

  public void OnSubmit()
  {
    Text = "Submitting form";
  }
}



class Subject
{
  private List<IEventListener> _subscribers = new List<IEventListener>();
  public void AddSubscriber(IEventListener subscriber)
  {
    _subscribers.Add(subscriber);
  }
  public void RemoveSubscriber(IEventListener subscriber)
  {
    _subscribers.Remove(subscriber);
  }
  protected void _notifySubscribers()
  {
    _subscribers.ForEach(subscriber => subscriber.OnSubmit());
  }
}

class SubmitButton : Subject
{
  public void Click()
  {
    _notifySubscribers();
  }
}



// підписання на події
var form = new LoginForm();
var tooltip = new Tooltip();
var button = new SubmitButton();

button.AddSubscriber(form);
button.AddSubscriber(tooltip);

button.Click();