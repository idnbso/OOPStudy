using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Iterator.HistoryBrowser
{
    public class Browser
    {
        public static void Run()
        {
            var history = new BrowserHistory();

            history.Push("www.google.com");
            history.Push("www.amazon.com");
            history.Push("www.bing.com");

            var iterator = history.CreateIterator();

            while (iterator.HasNext())
            {
                var url = iterator.Current();
                Console.WriteLine(url);
                iterator.Next();
            }
        }
    }
}
