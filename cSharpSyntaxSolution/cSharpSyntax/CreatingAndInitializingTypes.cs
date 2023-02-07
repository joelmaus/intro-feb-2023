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

            string myName = "Jeff"; // Initializing.
            char mi = 'M';

            bool isVendor = true;
            // delete me
            int myAge = 53;
            bool isLegalAgeToDrink = myAge >= 21;

            Taco food = new Taco();

            Assert.Equal("Jeff", myName);
            Assert.Equal(53, myAge);
            Assert.Equal("Birds", thingy);
        }

        [Fact]
        public void ImplictlyTypedLocalVariables()
        {
            // Var can be used for local variables, and you must initialize the variable.
            var myAge = 21;

            var r = new TransitoryPolicyCommuterRecord();
            var myName = "Jeff";

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
    }

    public class Taco { }
    public class TransitoryPolicyCommuterRecord { }