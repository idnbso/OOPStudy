using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware
{
    class EmptyHandler : Handler
    {
        public EmptyHandler() : base(null)
        {
        }

        public override bool DoHandle(HttpRequest request) => true;
    }
}
