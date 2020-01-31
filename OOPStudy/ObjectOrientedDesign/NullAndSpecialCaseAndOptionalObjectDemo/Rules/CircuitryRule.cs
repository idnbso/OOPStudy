using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    class CircuitryRule : ChainedRule
    {
        private Action<Action> ClaimAction { get; }

        public CircuitryRule(Action<Action> claimAction, IWarrantyRules next) : base(next)
        {
            this.ClaimAction = claimAction;
            this.Claim = this.Forward;
        }

        protected override void HandleCircuitryFailed()
        {
            this.Claim = this.ClaimAction;
        }

        protected override void HandleCircuitryOperational()
        {
            this.Claim = this.Forward;
        }
    }
}
