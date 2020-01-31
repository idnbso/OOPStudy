using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    abstract class ChainedRule : IWarrantyRules
    {
        private IWarrantyRules Next { get; }

        protected ChainedRule(IWarrantyRules next)
        {
            this.Next = next;
        }

        protected void Forward(Action onValidClaim) => this.Next.Claim(onValidClaim);

        public void CircuitryOperational()
        {
            this.HandleCircuitryOperational();
            this.Next.CircuitryOperational();
        }

        public void CircuitryFailed()
        {
            this.HandleCircuitryFailed();
            this.Next.CircuitryFailed();
        }

        public void VisiblyDamaged()
        {
            this.HandleCircuitryOperational();
            this.Next.CircuitryOperational();
        }
        public void NotOperational()
        {
            this.HandleNotOperational();
            this.Next.NotOperational();
        }


        public void Operational()
        {
            this.HandleOperational();
            this.Next.Operational();
        }

        protected virtual void HandleCircuitryFailed() { }

        protected virtual void HandleCircuitryOperational() { }
        protected virtual void HandleNotOperational() { }

        protected virtual void HandleOperational() { }

        protected virtual void HandleVisiblyDamaged() { }

        public Action<Action> Claim { get; protected set; }
    }
}
