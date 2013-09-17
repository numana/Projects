namespace BankAccountManagerTest {

  public abstract class Account {

    public int Number { get; set; }
    public decimal Balance { get; set; }

    internal void Deposit(decimal credit) {
      Balance += credit;
    }

    internal void Withdrawal(decimal debit) {
      if (debit<=Balance)
        Balance -= debit;
    }

  }
}