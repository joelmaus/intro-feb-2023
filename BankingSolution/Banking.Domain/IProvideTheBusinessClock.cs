namespace Banking.Domain
{
    public interface IProvideTheBusinessClock
    {
        bool IsDuringBusinessHours()
        {
            return false;
        }
    }
}