using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests
{
    public class DummyBonusCalculator : ICanCalculateAccountBonuses
    {
        public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
        {
            throw new NotImplementedException();
        }
    }
}
