using BankAccountManager.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountManagerTest {

  [TestClass]
  public class AtmTest {

    private readonly Atm _atm = new Atm();

    [TestInitialize]
    public void Initialize() {
      _atm.Accounts = new Account[] {
                   new SavingsAccount {Number = 1, Balance = 1000},
                   new CheckingAccount {Number = 2, Balance = 100},
                   new BusinessAccount {Number = 3, Balance = 10000}
                 };
    }

    [TestMethod]
    public void ClientSelectsSavingsAccountAndMakesSeriesOfDepositsAndWithdrawals() {
      var account = _atm.SelectAccount(1);
      account.Deposit(210);
      account.Deposit(100);
      account.Deposit(90);
      account.Withdrawal(80);
      Assert.AreEqual(1320, account.Balance);
    }

    [TestMethod]
    public void ClientSelectsCheckingAccountAndMakesSeriesOfDepositsAndWithdrawals() {
      var account = _atm.SelectAccount(2);
      account.Deposit(210);
      account.Deposit(100);
      account.Deposit(90);
      account.Withdrawal(80);
      Assert.AreEqual(420, account.Balance);
    }

    [TestMethod]
    public void ClientSelectsBusinessAccountAndMakesSeriesOfDepositsAndWithdrawals() {
      var account = _atm.SelectAccount(3);
      account.Deposit(210);
      account.Deposit(100);
      account.Deposit(90);
      account.Withdrawal(80);
      Assert.AreEqual(10320, account.Balance);
    }

  }
}
