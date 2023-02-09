using Banking.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.UnitTests.BonusCalculations
{
    public class StandardBonusCalculatorTests
    {
        [Fact]
        //deposits under 5000 get no bonus
        //deposits 5000+ during business hours get bonus
        //deposits with 5000+ outside business hours no bonus
        public void UnderCutoffGetNoBonus()
        {
            ICanCalculateAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(4999.99M, 100);

            Assert.Equal(0, bonus);
        }

        [Fact]
        //deposits under 5000 get no bonus
        //deposits 5000+ during business hours get bonus
        //deposits with 5000+ outside business hours no bonus
        public void AtCutoffGetNoBonus()
        {
            ICanCalculateAccountBonuses calculator = new StandardBonusCalculator();

            var bonus = calculator.GetDepositBonusFor(5000M, 100);

            Assert.Equal(10, bonus);
        }


    }
}
