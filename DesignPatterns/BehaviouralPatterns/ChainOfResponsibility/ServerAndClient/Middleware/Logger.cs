using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware
{
    class Logger : Handler
    {
        public Logger(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Log(request);
            return false;
        }

        public void Log(HttpRequest request)
        {
            Console.WriteLine($"[{DateTime.Now}] {request}");
        }
    }
}
