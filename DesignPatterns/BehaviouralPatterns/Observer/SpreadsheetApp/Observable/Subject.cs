using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp
{
    public abstract class Subject
    {
        private List<IObserver> observers = new List<IObserver>();

        public virtual void AddObserver(IObserver observer) => observers.Add(observer);
        public virtual void RemoveObserver(IObserver observer) => observers.Remove(observer);
        protected virtual void NotifyObservers() => observers.ForEach(o => o.Update());
    }
}
