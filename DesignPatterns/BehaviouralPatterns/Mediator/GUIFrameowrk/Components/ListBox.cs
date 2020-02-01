using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    public class ListBox : UIControl
    {
        public ListBox(DialogBox dialogOwner) : base(dialogOwner)
        {
        }

        private string _selection;
        public string Selection 
        {
            get => _selection;
            set 
            { 
                _selection = value;
                dialogOwner.OnChanged(this);
            } 
        }
    }
}
