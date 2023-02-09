using Banking.Domain;

namespace Banking.UnitTests;

    public class NewAccounts
    {

        [Fact]
        public void NewAccountsHaveTheCorrectOpeningBalance()
        {
            //given I have new bank account
            var accounts = new BankAccount(new DummyBonusCalculator());

            //when i ask that account for its balance
            decimal openingBalance = accounts.GetBalance();

            //then it has a balance of 5,000.00
            Assert.Equal(5000M, openingBalance);

        }

    }
