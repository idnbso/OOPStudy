using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehaviouralPatterns.Memento.CodeEditor
{
    class EditorHistory
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state) => states.Add(state);

        public EditorState Pop()
        {
            if (states.Count == 0) { return new EditorState(); }

            Func<int> getStatesLastIndex = () => states.Count - 1;
            states.RemoveAt(getStatesLastIndex());
            return states[getStatesLastIndex()]; // current state
        }

        public override string ToString() => $"History:\n{string.Join("\n", states.Select(s => $"{s}"))}";
    }
}
