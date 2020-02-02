using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations
{
    public class PlainTextOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("text-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("text-anchor");
        }
    }
}
