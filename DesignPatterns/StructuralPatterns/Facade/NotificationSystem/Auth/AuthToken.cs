using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem.Auth
{
    public class AuthToken
    {
        private string appId;
        private string key;

        public AuthToken(string appId, string key)
        {
            this.appId = appId;
            this.key = key;
        }

        public override string ToString() => $"{appId}.{key}.225425asds44535sa335";
    }
}
