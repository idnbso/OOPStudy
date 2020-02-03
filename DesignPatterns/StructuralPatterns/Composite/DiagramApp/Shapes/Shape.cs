using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite.DiagramApp.Shapes
{
    class Shape : IComponent
    {
        private string Name;

        public Shape(string name)
        {
            this.Name = name;
        }

        public void Render()
        {
            Console.WriteLine($"Render shape: {Name}");
        }

        public void Move()
        {
            Console.WriteLine($"Moves shape: {Name}");
        }
    }
}
