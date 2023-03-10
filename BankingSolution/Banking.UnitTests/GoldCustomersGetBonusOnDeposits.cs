using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
   public class GoldCustomersGetBonusOnDeposits
    {

        [Fact]
        public void BonusAppliedToDeposit()
        {
            var account = new BankAccount();
            var openingBalance = account.GetBalance();
            var amountToDeposit = 100M;

            account.Deposit(amountToDeposit);

            Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
        }
    }
}
