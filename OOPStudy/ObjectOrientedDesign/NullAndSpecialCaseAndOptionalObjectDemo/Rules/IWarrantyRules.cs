using System;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Rules
{
    public interface IWarrantyRules
    {
        Action<Action> Claim { get; }
        void VisiblyDamaged();
        void CircuitryFailed();
        void CircuitryOperational();
        void NotOperational();
        void Operational();
    }
}