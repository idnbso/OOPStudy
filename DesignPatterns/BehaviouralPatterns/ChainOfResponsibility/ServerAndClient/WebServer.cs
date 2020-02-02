using DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient
{
    public class WebServer
    {
        private Handler handler;

        public WebServer() => this.handler = new EmptyHandler();

        public WebServer(Handler handler) => this.handler = handler;

        public void Handle(HttpRequest request) => handler.Handle(request);
    }
}
