using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight.MapsApp.Point
{
    class PointIconFactory
    {
        /// <summary>
        /// Dictionary of point icons singletons.
        /// </summary>
        private Dictionary<PointType, PointIcon> pointIcons = new Dictionary<PointType, PointIcon>()
        {
            { PointType.Default, new PointIcon(PointType.Default, new byte[20]) },
            { PointType.Cafe, new PointIcon(PointType.Cafe, new byte[23]) },
            { PointType.Restaurant, new PointIcon(PointType.Restaurant, new byte[25]) }
        };

        public PointIcon GetPointIcon(PointType pointType) => pointIcons.TryGetValue(pointType, out PointIcon pointIcon) ? 
            pointIcon : pointIcons[PointType.Default];
    }
}
