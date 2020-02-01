using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Iterator.HistoryBrowser
{
    public interface IIterator<T>
    {
        void Next();

        T Current();

        bool HasNext();
    }
}
