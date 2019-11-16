using OOPStudy.BranchingDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.ValueObjectsDemo
{
    class ValueObjectsDemo
    {
        static bool IsHappyHour { get; set; }
        
        static MoneyAmount Reserve (MoneyAmount cost)
        {
            // The bug: The cost variable is the alias. We are using the alias to mutate the object.
            //cost.Amount += 2; // reservation fee

            decimal factor = 1;
            MoneyAmount newCost = cost;
            if (IsHappyHour)
            {
                factor = .5M;
            }

            Console.WriteLine("\nReserving an item that costs {0}.", newCost);
            return cost.Scale(factor);
        }

        static void Buy(MoneyAmount wallet, MoneyAmount cost)
        {
            bool enoughMoney = wallet.Amount >= cost.Amount;

            MoneyAmount finalCost =  Reserve(cost);

            bool finalEnough = wallet.Amount >= finalCost.Amount;

            if (enoughMoney)
            {
                Console.WriteLine("You will pay {0} with your {1}.", cost, wallet);
            }
            else if (finalEnough)
            {
                Console.WriteLine("{0} will be enough to pay {1}.", wallet, finalCost);
            }
            else
            {
                Console.WriteLine("You cannot pay {0} with your {1}.", cost, wallet);
            }
        }

        static void RunDemo()
        {
            Buy(new MoneyAmount(12M, "USD"),
                new MoneyAmount(10M, "USD"));

            Buy(new MoneyAmount(7M, "USD"),
                new MoneyAmount(10M, "USD"));

            IsHappyHour = true;
            Buy(new MoneyAmount(7M, "USD"),
                new MoneyAmount(10M, "USD"));

            Console.ReadLine();

            /////////////////////////////////////////////////

            MoneyAmount x = new MoneyAmount(2, "USD");
            MoneyAmount y = new MoneyAmount(4, "USD");

            if (x.Equals(y))
            {
                Console.WriteLine("Equal.");
            }
            if ((x*2).Equals(y))
            {
                Console.WriteLine("Equal after scaling.");
            }

            /////////////////////////////////////////////////

            MoneyAmount a = new MoneyAmount(2, "USD");
            MoneyAmount b = new MoneyAmount(2, "USD");

            var set = new HashSet<MoneyAmount>();
             
            set.Add(a);

            if (set.Contains(b))
                Console.WriteLine("Cannot add repeated value.");
            else
                set.Add(b);

            if (a == b)
                Console.WriteLine("values are equal");
            if (a != b)
                Console.WriteLine("values are not equal");

            Console.WriteLine("Count = {0}", set.Count);
            Console.ReadLine();
        }
    }
}
