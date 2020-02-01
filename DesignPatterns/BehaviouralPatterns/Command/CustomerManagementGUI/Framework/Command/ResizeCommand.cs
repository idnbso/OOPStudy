using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command
{
    public class ResizeCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Resizing");
        }
    }
}
