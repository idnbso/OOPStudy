using System;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    public interface IWarrantyRulesFactory
    {
        IWarrantyRules Create(Action<Action> claimMoneyBack, Action<Action> claimNotOperationalWarranty, Action<Action> claimCircuitryWarranty);
    }
}