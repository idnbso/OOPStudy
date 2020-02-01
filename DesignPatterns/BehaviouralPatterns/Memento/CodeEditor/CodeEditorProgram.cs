using DesignPatterns.BehaviouralPatterns.Memento.CodeEditor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.CodeEditor
{
    public class CodeEditorProgram
    {
        public static void Demo()
        {
            var editorManager = new EditorManager();
            editorManager.Run();
        }
    }
}
