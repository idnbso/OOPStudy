using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework;
using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Components
{
    public class Button
    {
        public string Label { get; set; }
        private readonly ICommand command;

        public Button(ICommand command)
        {
            this.command = command;
        }

        public Button(string label, ICommand command)
        {
            Label = label;
            this.command = command;
        }

        public void Click()
        {
            command.Execute();
        }
    }
}
