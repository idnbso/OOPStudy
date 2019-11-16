using System;

namespace OOPStudy.BranchingDemo
{
    public class Money : IComparable<Money>
    {
        public decimal Amount { get; set; }
        public string CurrencySymbol { get; set; }

        public Money(double amount)
        {
            this.Amount = (decimal)amount;
        }

        public Money(Money money)
        {
            this.Amount = money.Amount;
            this.CurrencySymbol = money.CurrencySymbol;
        }

        public Money()
        {
        }

        public override string ToString() => $"{this.Amount} {this.CurrencySymbol}";

        #region Operators Overloading

        public static Money operator +(Money x, decimal amount)
        {
            x.Amount += amount;
            return x;
        }

        public static Money operator -(Money x, decimal amount)
        {
            x.Amount -= amount;
            return x;
        }

        public static Money operator +(Money x, Money y)
        {
            // TODO: check if same currency, else convert amount and only then increment
            x.Amount += y.Amount;
            return x;
        }

        public static Money operator /(Money x, double y)
        {
            x.Amount /= (decimal)y;
            return x;
        }

        public static Money operator *(Money x, double y)
        {
            x.Amount *= (decimal)y;
            return x;
        }

        public static bool operator <(Money x, Money y)
        {
            // TODO: check if same currency, else convert amount and only then increment
            return x.Amount < y.Amount;
        }

        public static bool operator >(Money x, Money y)
        {
            // TODO: check if same currency, else convert amount and only then increment
            return x.Amount > y.Amount;
        }

        #endregion

        public int CompareTo(Money other)
        {
            return this.Amount.CompareTo(other.Amount);
        }

        // similarly to incrementations are subtraction, multiplication, etc...
    }
}