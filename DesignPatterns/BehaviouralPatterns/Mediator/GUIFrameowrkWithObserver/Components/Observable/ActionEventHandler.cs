using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components.Observable
{
    class ActionEventHandler : IEventHandler
    {
        private Action action;

        public ActionEventHandler(Action action)
        {
            this.action = action;
        }

        public void Handle() => action();
    }
}
