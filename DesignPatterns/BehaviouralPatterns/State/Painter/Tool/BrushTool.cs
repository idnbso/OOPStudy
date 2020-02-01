using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.State.Painter.Tool
{
    class BrushTool : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Show the Brush icon.");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line.");
        }
    }
}
