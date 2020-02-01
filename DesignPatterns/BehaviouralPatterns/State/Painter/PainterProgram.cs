using DesignPatterns.BehaviouralPatterns.State.Painter.Tool;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.State.Painter
{
    public class PainterProgram
    {
        public static void Demo()
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseDown();
            canvas.MouseUp();

            canvas.CurrentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
