using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    public class Button : UIControl
    {
        public Button(DialogBox dialogOwner) : base(dialogOwner)
        {
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                dialogOwner.OnChanged(this);
            }
        }
    }
}
