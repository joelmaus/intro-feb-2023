using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpSyntax
{
    public class CreatingAndInitializingTypes {

        string thingy = "Birds";

        [Fact]
        public void UsingLiteralsToCreateInstancesOfTypes()
        {
            // local variabled -- variables that are declared inside a method, or property.

            string myName = "Joel"; // Initializing.
            char mi = 'D';

            bool isVendor = true;
            // delete me
            int myAge = 53;
            bool isLegalAgeToDrink = myAge >= 21;

            Taco food = new Taco();

            Assert.Equal("Joel", myName);
            Assert.Equal(35, myAge);
            Assert.Equal("Birds", thingy);
        }

        [Fact]
        public void ImplictlyTypedLocalVariables()
        {
            // Var can be used for local variables, and you must initialize the variable.
            var myAge = 21;

            var r = new TransitoryPolicyCommuterRecord();
            var myName = "Joel";

            var favoriteFood = new Taco();

            var myPay = 25.23M;

            // option in c# 6, we don't use this much except in special circumstances I'll show later.

            Taco lunch = new();
            Assert.IsType<Taco>(lunch);


        }

        [Fact]
        public void CurlyBracesCreateScopes()
        {
            Assert.Equal("Birds", thingy);
            var message = "";
            var age = 22;
            if (age >= 21)
            {
                message = "Old Enough";
            }

            Assert.Equal(message, "Old Enough");
        }
        [Fact]
        public void MutableStringsWithStringBuilders()
        {
            var message = new StringBuilder();

            foreach(var num in Enumerable.Range(1,10000))
            {
                message.Append(num.ToString() + ", ");
            }
            Assert.True(message.ToString().StartsWith("1, 2, 3, 4"));
        }


        [Fact]
        public void MoreAboutStrings()
        {
            var name = "Bob";
            var age = 33;

            var message = name + " is " + age;
            var message2 = string.Format("{0} is {1}", name, age);
            var message3 = $"{name} is {age}";
        }
        [Fact]
        public void DoingConversionsOnTypes()
        {
            string myPay = "100.83Tacos";

            if (decimal.TryParse(myPay, out decimal payAsNumber))
            {
                Assert.Equal(10_000.83M, payAsNumber);
            }
            else
                Assert.True(false);

            var birthdate = DateTime.Parse("09/10/1987"); 

        }


    }

    public class Taco { }
    public class TransitoryPolicyCommuterRecord { }