using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    class MoneyBackRule : ChainedRule
    {
        public MoneyBackRule(Action<Action> claimAction, IWarrantyRules next) : base(next)
        {
            this.Claim = claimAction;
        }

        protected override void HandleCircuitryFailed()
        {
            this.Claim = this.Forward;
        }

        protected override void HandleVisiblyDamaged()
        {
            this.Claim = this.Forward;
        }

        protected override void HandleNotOperational()
        {
            this.Claim = this.Forward;
        }
    }
}
