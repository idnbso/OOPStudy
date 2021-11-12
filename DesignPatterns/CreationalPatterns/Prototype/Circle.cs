using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Prototype.Keynote
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }

        public void Render()
        {
            Console.WriteLine("Rendering a circle.");
        }
        public IComponent Clone()
        {
            return new Circle
            {
                Radius = Radius
            };
        }
    }
}
