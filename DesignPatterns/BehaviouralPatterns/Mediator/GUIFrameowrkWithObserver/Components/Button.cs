using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components
{
    public class Button : UIControl
    {
        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                NotifyEventHandlers();
            }
        }


    }
}
