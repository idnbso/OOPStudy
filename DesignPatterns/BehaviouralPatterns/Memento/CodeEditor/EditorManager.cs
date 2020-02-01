using Memento.CodeEditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Memento.CodeEditor
{
    class EditorManager
    {
        public void Run()
        {
            var editor = new Editor();
            var history = new EditorHistory();

            editor.Title = $"Title {atoi("a")}";
            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Title = $"Title {atoi("b")}";
            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Title = $"Title {atoi("c")}";
            editor.Content = "c";
            editor.FontName = "Tahoma";
            editor.FontSize = 10;
            history.Push(editor.CreateState());
            Console.WriteLine($"\n{editor}");

            Console.WriteLine($"\n{history}");

            editor.Restore(history.Pop());
            Console.WriteLine($"\n{editor}");
        }

        private int atoi(string s) => s.Length == 0 ? 0 : Convert.ToInt32(Convert.ToChar(char.ToLower(s[0])) - Convert.ToInt32('a')) + 1;
    }
}
