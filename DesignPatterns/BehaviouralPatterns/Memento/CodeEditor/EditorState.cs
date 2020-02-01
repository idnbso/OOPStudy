using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Memento.CodeEditor
{
    public class EditorState
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string FontName { get; set; }
        public int FontSize { get; set; }

        public override string ToString()
        {
            return $"Document with Font {FontName} {FontSize}px:\n{Title} - {Content}";
        }
    }
}
