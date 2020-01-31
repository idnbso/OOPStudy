using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.NullAndSpecialCaseAndOptionalObjectDemo.Warranty
{
    interface IWarrantyMapFactory
    {
        IReadOnlyDictionary<DeviceStatus, Action<Action>> Create(
            Action<Action> claimMoneyBack,
            Action<Action> claimNotOperational,
            Action<Action> claimCircuitry
            );
    }
}
