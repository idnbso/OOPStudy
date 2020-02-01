using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.Command
{
    public class CommandsHistory
    {
        private Deque<IUndoableCommand> commands = new Deque<IUndoableCommand>();

        public void Push(IUndoableCommand command) => commands.AddFirst(command);

        public IUndoableCommand Pop() => commands.TryPopFirst(out IUndoableCommand command) ? command : new EmptyCommand();

        public int Size() => commands.Count;
    }
}
