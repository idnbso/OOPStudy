using DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Nodes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Visitor.HtmlEditor.Operations
{
    public interface IOperation
    {
        void Apply(HeadingNode heading);
        void Apply(AnchorNode anchor);
    }
}
