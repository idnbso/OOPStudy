using DesignPatterns.BehaviouralPatterns.Command.HtmlEditor.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.HtmlEditor
{
    public class HtmlEditor
    {
        public static void Run()
        {
            var history = new CommandsHistory();
            var document = new HtmlDocument();
            document.Content = "Hello World!";

            var boldCommand = new BoldCommand(document, history);
            boldCommand.Execute();

            Console.WriteLine(document.Content);

            var undoCommand = new UndoCommand(history);
            undoCommand.Execute();

            Console.WriteLine(document.Content);
        }
    }
}
