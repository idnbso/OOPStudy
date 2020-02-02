using DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient.Middleware;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.ChainOfResponsibility.ServerAndClient
{
    public class WebApplication
    {
        public static void Run()
        {
            var encryptor = new Encryptor(new EmptyHandler());
            var compressor = new Compressor(next: encryptor);
            var logger = new Logger(next: compressor);
            var authenticator = new Authenticator(next: logger);

            var server = new WebServer(authenticator);
            server.Handle(new HttpRequest() { Username = "admin", Password = "1234" });
        }
    }
}
