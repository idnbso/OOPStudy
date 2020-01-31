using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    class ChristmasRules : IWarrantyRulesFactory
    {
        public IWarrantyRules Create(Action<Action> claimMoneyBack, Action<Action> claimNotOperationalWarranty, Action<Action> claimCircuitryWarranty) =>
            new ConditionalRule(IsAroundChristmas, claimMoneyBack,
                new DefaultRules().Create(claimMoneyBack, claimNotOperationalWarranty, claimCircuitryWarranty));

        private bool IsAroundChristmas() => DateTime.Today.Month == 12;
    }
}
