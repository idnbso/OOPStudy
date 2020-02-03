using DesignPatterns.StructuralPatterns.Composite.DiagramApp.Shapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite.DiagramApp
{
    public class DiagramEditor
    {
        public static void Run()
        {
            var group1 = new Group();
            group1.Add(new Shape("Square 1")); // square
            group1.Add(new Shape("Square 2")); // square

            var group2 = new Group();
            group2.Add(new Shape("Circle 1")); // circle
            group2.Add(new Shape("Circle 2")); // circle

            var group = new Group();
            group.Add(group1);
            group.Add(group2);

            group.Render();
            group.Move();
        }
    }
}
