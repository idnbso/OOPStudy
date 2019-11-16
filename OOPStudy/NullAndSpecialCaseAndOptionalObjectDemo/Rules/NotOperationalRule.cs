using System;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    class NotOperationalRule : ChainedRule
    {
        private Action<Action> ClaimAction { get; }

        public NotOperationalRule(Action<Action> claimAction, IWarrantyRules next) : base(next)
        {
            this.ClaimAction = claimAction;
            this.Claim = this.Forward;
        }

        protected override void HandleNotOperational()
        {
            this.Claim = this.ClaimAction;
        }

        protected override void HandleOperational()
        {
            this.Claim = this.Forward;
        }
    }
}