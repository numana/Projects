using System.Linq;

namespace BankAccountManagerTest {

  public class Atm {

    public Account[] Accounts { get; set; }

    public Account SelectAccount(int i) {
      return Accounts.FirstOrDefault(a => a.Number == i);
    }

  }
}