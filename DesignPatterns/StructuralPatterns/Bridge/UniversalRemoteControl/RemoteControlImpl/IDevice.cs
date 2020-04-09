using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl
{
    interface IDevice
    {
        string Name { get; }
        void TurnOn();
        void TurnOff();
        void SetChannel(int channelNumber);
    }
}
