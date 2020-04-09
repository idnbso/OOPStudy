using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight.MapsApp.Point
{
    class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }

        public List<Point> GetPoints()
        {
            return new List<Point>()
            {
                new Point(x: 1, y: 2, iconFactory.GetPointIcon(PointType.Cafe)),
                new Point(x: 3, y: 4, iconFactory.GetPointIcon(PointType.Restaurant))
            };
        }
    }
}
