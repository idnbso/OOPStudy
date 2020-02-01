using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    public class TextBox : UIControl
    {
        public TextBox(DialogBox dialogOwner) : base(dialogOwner)
        {
        }

        private string _content;
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                dialogOwner.OnChanged(this);
            }
        }
    }
}
