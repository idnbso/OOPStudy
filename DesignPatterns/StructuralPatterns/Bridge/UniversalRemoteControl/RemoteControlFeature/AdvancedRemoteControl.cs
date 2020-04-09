using DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlFeature
{
    class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public override void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Setting {device.Name} advanced features for channel {channelNumber}");
            // device.SetVolume(50);
            device.SetChannel(channelNumber);
        }
    }
}
