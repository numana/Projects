using BankAccountManager.Data.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccountManagerTest {

  [TestClass]
  public class BankAccountManagerTest {

    private BusinessAccount _bankAccount;

    [TestInitialize]
    public void Initialize() {
      _bankAccount = new BusinessAccount();
    }

    [TestMethod]
    public void WhenDepositIs100AndBalanceIs0AccountBalanceIs100() {
      _bankAccount.Balance = 0;
      _bankAccount.Deposit(100);
      Assert.AreEqual(100, _bankAccount.Balance);
    }

    [TestMethod]
    public void WhenDepositIs100AndBalanceIs10AccountBalanceIs110() {
      _bankAccount.Balance = 10;
      _bankAccount.Deposit(100);
      Assert.AreEqual(110, _bankAccount.Balance);
    }

    [TestMethod]
    public void WhenWithdrawalIsGreaterThanBalanceWithdrawalIsRejected() {
      _bankAccount.Balance = 0;
      _bankAccount.Withdrawal(100);
      Assert.AreEqual(0, _bankAccount.Balance);
    }

    [TestMethod]
    public void WhenWithdrawalIsLessOrEqualToBalanceWithdrawalIsAcccepted() {
      _bankAccount.Balance = 110;
      _bankAccount.Withdrawal(100);
      Assert.AreEqual(10, _bankAccount.Balance);
    }

  }
}
