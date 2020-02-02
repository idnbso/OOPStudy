using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations
{
    public class HighlightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}
