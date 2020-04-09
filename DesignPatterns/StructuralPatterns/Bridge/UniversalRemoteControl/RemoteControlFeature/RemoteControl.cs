using DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlFeature
{
    class RemoteControl : IDevice
    {
        protected IDevice device;

        public string Name => device.Name;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TurnOn() => device.TurnOn();

        public void TurnOff() => device.TurnOff();

        public virtual void SetChannel(int channelNumber) => device.SetChannel(channelNumber);
    }
}
