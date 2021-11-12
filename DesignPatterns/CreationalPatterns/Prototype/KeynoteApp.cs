using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.Keynote
{
    public class KeynoteApp
    {
        public static void Run()
        {
            var menu = new ContextMenu();
            var circleA = new Circle();
            var circleB = menu.Duplicate(circleA);
            var circleC = menu.Duplicate(circleA);

            circleA.Render();
            circleB.Render();
            circleC.Render();
        }
    }
}
