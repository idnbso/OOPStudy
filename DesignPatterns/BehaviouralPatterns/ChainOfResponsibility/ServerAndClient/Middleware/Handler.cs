using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient
{
    public abstract class Handler
    {
        private Handler next;

        public Handler(Handler next)
        {
            this.next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request)) { return; }

            next.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}
