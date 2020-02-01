using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components
{
    public class TextBox : UIControl
    {
        private string _content;
        public string Content
        {
            get => _content;
            set
            {
                _content = value;
                NotifyEventHandlers();
            }
        }
    }
}
