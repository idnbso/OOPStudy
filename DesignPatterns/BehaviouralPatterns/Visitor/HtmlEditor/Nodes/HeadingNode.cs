using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes
{
    public class HeadingNode : IHtmlNode
    {
        public void Execute(IOperation operation)
        {
            operation.Apply(heading: this);
        }
    }
}
