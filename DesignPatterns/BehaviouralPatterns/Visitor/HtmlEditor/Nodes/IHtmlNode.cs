using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes
{
    public interface IHtmlNode
    {
        void Execute(IOperation operation);
    }
}
