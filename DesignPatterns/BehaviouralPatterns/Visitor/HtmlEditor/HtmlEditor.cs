using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes;
using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor
{
    public class HtmlEditor
    {
        public static void Run()
        {
            var document = new HtmlDocument();
            document.Add(new HeadingNode());
            document.Add(new AnchorNode());

            var highlightOperation = new HighlightOperation();
            document.Execute(highlightOperation);

            var plainTextOperation = new PlainTextOperation();
            document.Execute(plainTextOperation);
        }
    }
}
