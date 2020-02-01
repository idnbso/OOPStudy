using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.Command
{
    public class BoldCommand : IUndoableCommand
    {
        private string previousContent;
        private HtmlDocument document;
        private CommandsHistory history;

        public BoldCommand(HtmlDocument document, CommandsHistory history)
        {
            this.document = document;
            this.history = history;
        }

        public void Execute()
        {
            previousContent = document.Content;
            document.MakeBold();
            history.Push(command: this); // requires a new instance for each bold command that needs to be executed/unexecuted separetly
        }

        public void Unexecute()
        {
            document.Content = previousContent;
        }
    }
}
