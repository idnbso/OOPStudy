using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    /// <summary>
    /// An object which terminates the chain of calls by doing nothing.
    /// </summary>
    class NotSatisfiedRule : IWarrantyRules
    {
        public Action<Action> Claim => (action) => { };

        public void CircuitryFailed() { }

        public void CircuitryOperational() { }

        public void NotOperational() { }

        public void Operational() { }

        public void VisiblyDamaged() { }
    }
}
