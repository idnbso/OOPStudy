using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor
{
    public interface IUndoableCommand : ICommand
    {
        void Unexecute();
    }
}
