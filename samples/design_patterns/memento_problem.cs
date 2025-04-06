class BankAccount
{
  private List<BankAccount> _history = new List<BankAccount>();
  private double _amount;
  private string _currency;

  public BankAccount(double initialAmount, string currency)
  {
    this._amount = initialAmount;
    this._currency = currency;
    SaveToHistory();
  }

  public double Deposit(double amountChange)
  {
    this._amount += amountChange;
    SaveToHistory();
    return this._amount;
  }

  public void ChangeCurrency(string to)
  {
    this._currency = to;
    this._amount = Math.Round(this._amount * new Random().NextDouble(), 2);
    SaveToHistory();
  }

  public override string ToString()
  {
    return $"{this._amount} {this._currency}";
  }

  public int SaveToHistory()
  {
    this._history.Add((BankAccount)this.MemberwiseClone());
    return this._history.Count - 1;
  }

  public void Restore(int index)
  {
    BankAccount snapshot = this._history.ElementAt(index);
    this._history.RemoveRange(index, this._history.Count - index);
    this._amount = snapshot._amount;
    this._currency = snapshot._currency;
  }

  public void Undo() { }
  public void PrintTransactions() { }
}