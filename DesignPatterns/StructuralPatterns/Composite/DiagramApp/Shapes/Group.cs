using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Composite.DiagramApp.Shapes
{
    class Group : IComponent
    {
        private IList<IComponent> shapes = new List<IComponent>();

        public void Add(IComponent component) => shapes.Add(component);

        public void Render()
        {
            foreach (var shape in shapes)
            {
                shape.Render();
            }
        }

        public void Move()
        {
            foreach (var shape in shapes)
            {
                shape.Move();
            }
        }
    }
}
