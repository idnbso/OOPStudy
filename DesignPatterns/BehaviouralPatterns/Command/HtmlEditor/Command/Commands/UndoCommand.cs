using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.Command
{
    public class UndoCommand : ICommand
    {
        private CommandsHistory history;

        public UndoCommand(CommandsHistory history)
        {
            this.history = history;
        }

        public void Execute() => history.Pop().Unexecute();
    }
}
