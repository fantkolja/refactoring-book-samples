class Input
{
  public bool Validate() {}
}

class SubmitButton
{
  public void Click() {}
}

class Tooltip
{
  public SubmitButton WrappedButton { set; get; }
  public string Text { set; get; }
}

class LoginForm
{
  public List<Input> Inputs = new List<Input>();
  public SubmitButton Button = new SubmitButton();

  public void ValidateInputs() { }
}

var input1 = new Input();
var input2 = new Input();
var button = new SubmitButton();
var form = new LoginForm();
var tooltip = new Tooltip();

form.Inputs.Add(input1);
form.Inputs.Add(input2);
form.Button = button;
tooltip.WrappedButton = button;

button.Click(); // потрібно викликати form.ValidateInputs() і змінити tooltip.Text