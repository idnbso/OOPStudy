using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.CodeEditor
{
    public class CodeEditorProgram
    {
        public static void Demo()
        {
            var editor = new Editor();

            editor.setContent("a");
            editor.setContent("b");
            editor.setContent("c");
            Console.WriteLine(editor);

            editor.undo();

            Console.WriteLine(editor);
        }
    }
}
