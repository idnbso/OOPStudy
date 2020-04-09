using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem
{
    class NotificationService
    {
        public void Send(string message, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect(ipAddress: "192.20.165.2");
            var authToken = server.Authenticate(appId: "AppId", key: "key");
            server.Send(authToken, new Message(content: message), target);

            connection.Disconnect();
        }
    }
}
