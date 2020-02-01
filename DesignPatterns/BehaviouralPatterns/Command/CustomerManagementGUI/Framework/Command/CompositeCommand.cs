using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command
{
    public class CompositeCommand : ICommand
    {
        private List<ICommand> commands = new List<ICommand>();

        public void Add(ICommand command) => commands.Add(command);

        public void Execute() => commands.ForEach(c => c.Execute());
    }
}
