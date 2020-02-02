using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware
{
    class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public bool Authenticate(HttpRequest request)
        {
            var isValid = request.Username == "admin" && request.Password == "1234";

            Console.WriteLine($"Authenticated user {request.Username}");
            return !isValid;
        }

        public override bool DoHandle(HttpRequest request) => Authenticate(request);
    }
}
