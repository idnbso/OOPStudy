using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.Command
{
    class EmptyCommand : IUndoableCommand
    {
        public void Execute() { return; }


        public void Unexecute() { return; }
    }
}
