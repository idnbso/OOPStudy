using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command
{
    public class BlackAndWhiteFilterCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Applying Black and White Filter");
        }
    }
}
