namespace Banking.Domain
{
    public class BankAccount
    {
        private decimal _balance = 5000M;
        private ICanCalculateAccountBonuses _bonusCalculator;

        public BankAccount(ICanCalculateAccountBonuses bonusCalculator)
        {
            _bonusCalculator = bonusCalculator;
        }

        public virtual void Deposit(decimal amountToDeposit)
        {
            decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
            _balance += amountToDeposit + bonus;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Withdraw(decimal amountToWithdraw)
        {
            if (NotOverdraft(amountToWithdraw))
                _balance -= amountToWithdraw;
        }

        private bool NotOverdraft(decimal amountToWithdraw)
        {
            return _balance >= amountToWithdraw;
        }
    }
}