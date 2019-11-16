using OOPStudy.BranchingDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.ValueObjectsDemo
{
    class NonValueObjectsDemo
    {
        static bool IsHappyHour { get; set; }

        static Money Reserve (Money cost)
        {
            // The bug: The cost variable is the alias. We are using the alias to mutate the object.
            cost.Amount += 2; // reservation fee

            Money newCost = cost;
            if (IsHappyHour)
            {
                newCost = new Money()
                {
                    Amount = cost.Amount * .5M,
                    CurrencySymbol = cost.CurrencySymbol
                };
            }

            Console.WriteLine("\nReserving an item that costs {0}.", newCost);
            return newCost;
        }

        static void Buy(Money wallet, Money cost)
        {
            bool enoughMoney = wallet.Amount >= cost.Amount;

            Money finalCost =  Reserve(cost);

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
            Buy(new Money() { Amount = 12, CurrencySymbol = "USD" },
                new Money() { Amount = 10, CurrencySymbol = "USD" });

            Buy(new Money() { Amount = 7, CurrencySymbol = "USD" },
                new Money() { Amount = 10, CurrencySymbol = "USD" });

            IsHappyHour = true;
            Buy(new Money() { Amount = 7, CurrencySymbol = "USD" },
                new Money() { Amount = 10, CurrencySymbol = "USD" });

            Console.ReadLine();
        }
    }
}
