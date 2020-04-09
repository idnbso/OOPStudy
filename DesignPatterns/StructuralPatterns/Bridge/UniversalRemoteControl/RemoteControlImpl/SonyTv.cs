using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Bridge.UniversalRemoteControl.RemoteControlImpl
{
    class SonyTV : IDevice
    {        
        string IDevice.Name => "SonyTV";

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"Sony: Set Channel {channelNumber}");
        }

        public void TurnOff()
        {
            Console.WriteLine("Sony: Turn Off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Sony: Turn On");
        }
    }
}
