namespace Banking.Domain
{
    public class StandardBonusCalculator : ICanCalculateAccountBonuses
    {
        private IProvideTheBusinessClock _businessClock;

        public StandardBonusCalculator(IProvideTheBusinessClock businessClock)
        {
            _businessClock = businessClock;
        }

        public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            return EligibleForBonus(balance) ? amountToDeposit * .10M : 0;
        }

        private bool EligibleForBonus(decimal balance) //makes a separate function to simplify code above
        {
            return balance >= 5000M && _businessClock.IsDuringBusinessHours();
        }
    }
}