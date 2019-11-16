using System;

namespace OOPStudy.SpecialCaseDemo
{
    interface IWarranty
    {
        void Claim(DateTime date, Action onValidClaim);
    }
}