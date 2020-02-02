using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware
{
    class Encryptor : Handler
    {
        public Encryptor(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine($"Encrypting request: {request}");
            return false;
        }
    }
}
