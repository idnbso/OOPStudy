using DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlFeature;
using DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl
{
    public class RemoteControlApp
    {
        public static void Run()
        {
            var remoteControl = new AdvancedRemoteControl(new SamsungTV());
            remoteControl.TurnOn();
            remoteControl.SetChannel(12);
        }
    }
}
