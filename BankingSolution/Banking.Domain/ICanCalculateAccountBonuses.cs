namespace Banking.Domain
{
    //A job description. Any class that implements thsi interface is promising it "can do" this job description
    public interface ICanCalculateAccountBonuses
    {
        decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit);
    }
}