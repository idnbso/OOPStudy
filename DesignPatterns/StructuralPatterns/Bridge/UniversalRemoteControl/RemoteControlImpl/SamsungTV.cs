using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl
{
    class SamsungTV : IDevice
    {        
        string IDevice.Name => "SamsungTV";

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"SamsungTV: Set Channel: {channelNumber}");
        }

        public void TurnOff()
        {
            Console.WriteLine($"SamsungTV: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine($"SamsungTV: Turn On");
        }
    }
}
