using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk
{
    public class UIControl
    {
        protected DialogBox dialogOwner;

        public UIControl(DialogBox dialogOwner)
        {
            this.dialogOwner = dialogOwner;
        }
    }
}
