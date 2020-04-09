using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight.MapsApp.Point
{
    /// <summary>
    /// The Flyweight object of the Point domain.
    /// </summary>
    class PointIcon
    {
        public PointType Type { get; set; } // 4 bytes
        public byte[] Icon { get; set; } // 20 kilobytes

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }
    }
}
