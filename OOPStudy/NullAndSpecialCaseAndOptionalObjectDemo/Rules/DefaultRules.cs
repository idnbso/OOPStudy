using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    class DefaultRules : IWarrantyRulesFactory
    {
        public IWarrantyRules Create(Action<Action> claimMoneyBack, Action<Action> claimNotOperationalWarranty, Action<Action> claimCircuitryWarranty) =>
            new NotOperationalRule(claimNotOperationalWarranty,
                new CircuitryRule(claimCircuitryWarranty, 
                    new MoneyBackRule(claimMoneyBack, 
                        new NotSatisfiedRule())));
    }
}
