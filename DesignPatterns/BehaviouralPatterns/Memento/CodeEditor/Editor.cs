using DesignPatterns.BehaviouralPatterns.Memento.CodeEditor;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.CodeEditor
{
    public class Editor
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string FontName { get; set; } = "Ariel";
        public int FontSize { get; set; } = 11; // pixels

        public EditorState CreateState() => new EditorState() { Title = Title, Content = Content, FontName = FontName, FontSize = FontSize };

        public void Restore(EditorState state)
        {
            Title = state.Title;
            Content = state.Content;
            FontName = state.FontName;
            FontSize = state.FontSize;
        }

        public override string ToString() => CreateState().ToString();
    }
}
