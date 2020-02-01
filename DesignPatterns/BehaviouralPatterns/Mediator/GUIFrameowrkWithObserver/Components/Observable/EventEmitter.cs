using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Mediator.GUIFrameowrkWithObserver.Components.Observable
{
    public abstract class EventEmitter
    {
        private List<IEventHandler> eventHandlers = new List<IEventHandler>();

        public virtual void AddEventHandler(IEventHandler observer) => eventHandlers.Add(observer);
        public virtual void RemoveEventHandler(IEventHandler observer) => eventHandlers.Remove(observer);
        protected virtual void NotifyEventHandlers() => eventHandlers.ForEach(o => o.Handle());
    }
}
