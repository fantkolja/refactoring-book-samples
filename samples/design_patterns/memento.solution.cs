public interface IBankAccountSnapshot
{
  public Guid Id { get; }
  public DateTime Date { get; }
  public void Restore();
}

class AccountSnapshotManager
{
  private List<IBankAccountSnapshot> _history = new List<IBankAccountSnapshot>();

  public void Save(IBankAccountSnapshot snapshot)
  {
    this._history.Add(snapshot);
  }
  public void Restore(int index)
  {
    var snapshot = this._history.ElementAt(index);
    snapshot.Restore();
  }
  public void Undo()
  {
    throw new NotImplementedException();
  }
  public void PrintTransactions()
  {
    throw new NotImplementedException();
  }
}

class BankAccount
{
  private double _amount;
  private string _currency;

  public BankAccount(double initialAmount, string currency)
  {
    this._amount = initialAmount;
    this._currency = currency;
  }

  public double Deposit(double amountChange)
  {
    this._amount += amountChange;
    return this._amount;
  }

  public void ChangeCurrency(string to)
  {
    double changeCourse = new Random().NextDouble();
    this._currency = to;
    this._amount = Math.Round(this._amount * changeCourse, 2);
  }

  public IBankAccountSnapshot CreateSnapshot()
  {
    return new BankAccountSnapshot(this);
  }

  public override string ToString()
  {
    return $"{this._amount} {this._currency}";
  }

  private class BankAccountSnapshot : IBankAccountSnapshot
  {
    public Guid Id { get; } = Guid.NewGuid();
    public DateTime Date { get; } = DateTime.Now;
    private readonly double _amount;
    private readonly string _currency;
    private readonly BankAccount _originalAccount;
    public BankAccountSnapshot(BankAccount account)
    {
      this._amount = account._amount;
      this._currency = account._currency;
      this._originalAccount = account;
    }

    public void Restore()
    {
      this._originalAccount._amount = this._amount;
      this._originalAccount._currency = this._currency;
    }
  }
}