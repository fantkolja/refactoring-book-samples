class User {
    public string Name { get; }
    private List<User> _contacts = new List<User>();

    public User(string name) {
        Name = name;
    }

    public void AddContact(User user) {
        _contacts.Add(user);
    }

    public void SendMessage(string message) {
        foreach (var user in _contacts) {
            user.ReceiveMessage(Name, message);
        }
    }

    public void ReceiveMessage(string sender, string message) {
        Console.WriteLine($"{sender} to {Name}: {message}");
    }
}

// Використання:
User alice = new User("Alice");
User bob = new User("Bob");
User charlie = new User("Charlie");

alice.AddContact(bob);
alice.AddContact(charlie);

alice.SendMessage("Hello, everyone!");
