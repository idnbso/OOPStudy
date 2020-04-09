using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Facade.NotificationSystem
{
    public class Message
    {
        public string Content { get; set; }

        public Message(string content)
        {
            Content = content;
        }

        public override string ToString() => Content;
    }
}
