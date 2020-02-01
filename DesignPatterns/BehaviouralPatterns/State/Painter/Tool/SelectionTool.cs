using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.State.Painter.Tool
{
    class SelectionTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show the Selection icon.");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle.");
        }
    }
}
