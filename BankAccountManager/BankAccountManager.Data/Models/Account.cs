namespace BankAccountManager.Data.Models {

  public abstract class Account {

    public int Number { get; set; }
    public decimal Balance { get; set; }

    public void Deposit(decimal credit) {
      Balance += credit;
    }

    public void Withdrawal(decimal debit) {
      if (debit<=Balance)
        Balance -= debit;
    }

  }
}