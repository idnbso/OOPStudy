using DesignPatterns.StructuralPatterns.Facade.NotificationSystem.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem
{
    public class NotificationServer
    {
        public Connection Connect(string ipAddress) => new Connection(ipAddress, name: "Notification Server");

        public AuthToken Authenticate(string appId, string key) => new AuthToken(appId, key);

        public void Send(AuthToken authToken, Message message, string target) => 
            Console.WriteLine($"Sending a message: {message} to {target} by using the auth token: {authToken}");
    }
}
