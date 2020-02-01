using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrk.Components;
using DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components.Observable;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components
{
    public abstract class UIControl : EventEmitter
    {
        protected UIControl() => Name = "UIControl";

        protected UIControl(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        protected override void NotifyEventHandlers()
        {
            Console.WriteLine($"Default Dialog Box lifecycle event for control {Name ?? ToString()} change.");

            base.NotifyEventHandlers();
        }
    }
}
