using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components
{
    public class ListBox : UIControl
    {
        private string _selection;
        public string Selection 
        {
            get => _selection;
            set 
            { 
                _selection = value;
                NotifyEventHandlers();
            } 
        }

        public ListBox(string name) : base(name) { }
    }
}
