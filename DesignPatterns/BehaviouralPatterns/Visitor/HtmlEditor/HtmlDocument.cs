using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes;
using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor
{
    public class HtmlDocument
    {
        private List<IHtmlNode> nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node) => nodes.Add(node);

        public void Execute(IOperation operation)
        {
            foreach (var node in nodes)
            {
                node.Execute(operation);
            }
        }
    }
}
