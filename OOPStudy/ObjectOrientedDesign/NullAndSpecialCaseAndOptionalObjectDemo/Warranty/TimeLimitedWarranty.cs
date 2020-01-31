using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.SpecialCaseDemo
{
    class TimeLimitedWarranty : IWarranty
    {
        private DateTime DateIssued { get; }
        private TimeSpan Duration { get; }

        public TimeLimitedWarranty(DateTime dateIssued, TimeSpan duration)
        {
            this.DateIssued = dateIssued.Date;
            this.Duration = TimeSpan.FromDays(duration.Days);
        }

        private bool IsValidOn(DateTime date) => date.Date >= this.DateIssued && date.Date < this.DateIssued + this.Duration;

        public void Claim(DateTime date, Action onValidClaim)
        {
            if (!this.IsValidOn(date)) return;

            onValidClaim();
        }
    }
}
