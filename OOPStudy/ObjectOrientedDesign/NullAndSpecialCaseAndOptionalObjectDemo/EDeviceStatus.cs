using System;

namespace OOPStudy.SpecialCaseDemo
{
    [Flags]
    enum EDeviceStatus
    {
        AllFine = 0,
        NotOperational = 1,
        VisiblyDamaged = 2,
        CircuitryFailed = 4
    }
}