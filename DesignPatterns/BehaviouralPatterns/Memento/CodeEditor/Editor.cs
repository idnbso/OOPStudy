using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento.CodeEditor
{
    public class Editor
    {
        private string content { get; set; }
        private List<string> contentHistory = new List<string>();

        public void setContent(string v)
        {
            contentHistory.Add(item: v);
            content = v;
        }

        public void undo()
        {
            contentHistory.RemoveAt(index: contentHistory.Count - 1);
        }

        public override string ToString()
        {
            return string.Join(", ", contentHistory);
        }
    }
}
