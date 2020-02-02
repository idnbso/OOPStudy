using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient
{
    public class HttpRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public override string ToString() => $"Request of username: {Username}";
    }
}
