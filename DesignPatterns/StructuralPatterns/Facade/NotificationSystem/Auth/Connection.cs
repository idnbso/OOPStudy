using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem.Auth
{
    public class Connection
    {
        private string name;
        private string ipAddress;

        public Connection(string ipAddress, string name)
        {
            this.ipAddress = ipAddress;
            this.name = name;
        }

        public void Disconnect()
        {
            Console.WriteLine($"Connection to {name} on {ipAddress} has disconnected.");
        }
    }
}
