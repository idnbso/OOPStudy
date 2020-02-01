using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components
{
    public abstract class DialogBox
    {
        public virtual void OnChanged(UIControl control)
        {
            Console.WriteLine($"Default Dialog Box lifecycle event for control {control} change.");
        }
    }
}
