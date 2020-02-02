using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware
{
    class Compressor : Handler
    {
        public Compressor(Handler next) : base(next)
        {
        }

        public bool Compress(HttpRequest request)
        {
            Console.WriteLine($"Compressed request: {request}");
            return false;
        }

        public override bool DoHandle(HttpRequest request) => Compress(request);
    }
}
