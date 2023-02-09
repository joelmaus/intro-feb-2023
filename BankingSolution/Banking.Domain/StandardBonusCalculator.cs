namespace Banking.Domain
{
    public class StandardBonusCalculator : ICanCalculateAccountBonuses
    {
        public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            return EligibleForBonus(balance) ? amountToDeposit * .10M : 0;
        }

        private static bool EligibleForBonus(decimal balance) //makes a separate function to simplify code above
        {
            return balance >= 5000M;
        }
    }
}