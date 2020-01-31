using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SpecialCaseDemo
{
    class LifetimeWarranty : IWarranty
    {
        private DateTime IssuingDate { get; }
        
        public LifetimeWarranty(DateTime issuingDate)
        {
            this.IssuingDate = issuingDate;
        }

        private bool IsValidOn(DateTime date) => date.Date >= this.IssuingDate;

        public void Claim(DateTime date, Action onValidClaim)
        {
            if (!this.IsValidOn(date)) return;

            onValidClaim();
        }
    }
}
