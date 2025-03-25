interface IChatMediator
{
  void SendMessage(string message, User user);
  void AddUser(User user);
}

class ChatMediator : IChatMediator
{
  private List<User> _users = new List<User>();

  public void AddUser(User user)
  {
    _users.Add(user);
    user.SetMediator(this);
  }

  public void SendMessage(string message, User sender)
  {
    foreach (var user in _users)
    {
      if (user != sender)
      {
        user.ReceiveMessage(sender.Name, message);
      }
    }
  }
}

class User
{
  public string Name { get; }
  private IChatMediator _mediator;

  public User(string name)
  {
    Name = name;
  }

  public void SetMediator(IChatMediator mediator)
  {
    _mediator = mediator;
  }

  public void SendMessage(string message)
  {
    _mediator.SendMessage(message, this);
  }

  public void ReceiveMessage(string sender, string message)
  {
    Console.WriteLine($"{sender} to {Name}: {message}");
  }
}

// Використання:
IChatMediator chat = new ChatMediator();
User alice = new User("Alice");
User bob = new User("Bob");
User charlie = new User("Charlie");

chat.AddUser(alice);
chat.AddUser(bob);
chat.AddUser(charlie);

alice.SendMessage("Hello, everyone!");

