using DesignPatterns.BehaviouralPatterns.State.Painter.Tool;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.State.Painter
{
    public class Canvas
    {
        public ITool CurrentTool { get; set; }

        public void MouseDown() => CurrentTool.MouseDown();
        
        public void MouseUp() => CurrentTool.MouseUp();
    }
}
