using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight.MapsApp.Point
{
    /// <summary>
    /// Represents a point of intereset.
    /// </summary>
    class Point
    {
        private int x; // 4 bytes
        private int y; // 4 bytes
        private PointIcon pointIcon;

        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"{pointIcon.Type} at ({x}, {y})");
        }
    }
}
