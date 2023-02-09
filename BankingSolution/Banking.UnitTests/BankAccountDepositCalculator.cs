using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
   public class BankAccountDepositCalculator
    {       
      [Fact]

     public void BonusAppliedToDeposit()
            {
            // Given
            var stubbedBonusCalculator = new Mock<ICanCalculateAccountBonuses>();
                var account = new BankAccount(new DummyBonusCalculator());
                var openingBalance = account.GetBalance();
                var amountToDeposit = 118.32M;

            stubbedBonusCalculator.Setup(calculator =>
            calculator.GetDepositBonusFor(account.GetBalance(), amountToDeposit)).Returns(42.18M); //returns if it is the exact input

                // When
                account.Deposit(amountToDeposit); // <- THIS IS THE SYSTEM UNDER TEST
                                                  // Then
                Assert.Equal(openingBalance + amountToDeposit + 42.18M, account.GetBalance());
            }
        public class StubbedBonusCalculator : ICanCalculateAccountBonuses
        {
            public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
            {
                if (balance == 500M && amountToDeposit == 118.32M)
                    return 42.18M;
                else
                    return 0;
                      
            }
        }

        }
}
