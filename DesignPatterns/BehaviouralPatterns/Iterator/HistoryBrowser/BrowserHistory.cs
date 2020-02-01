using DesignPatterns.BehaviouralPatterns.Iterator.HistoryBrowser;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Iterator.HistoryBrowser
{
    public partial class BrowserHistory
    {
        private List<string> urls = new List<string>();

        public IIterator<string> CreateIterator() => new ListIterator(this);

        public void Push(string url) => urls.Add(url);

        public string Pop()
        {
            if (urls.Count == 0) { return string.Empty; }

            var lastUrl = urls[urls.Count - 1];
            urls.Remove(lastUrl);
            return lastUrl;
        }

        class ListIterator : IIterator<string>
        {
            private BrowserHistory history;
            private int currentIndex;

            public ListIterator(BrowserHistory history) => this.history = history;

            public string Current() => history.urls[currentIndex];

            public bool HasNext() => currentIndex < history.urls.Count;

            public void Next() => currentIndex++;
        }
    }
}
