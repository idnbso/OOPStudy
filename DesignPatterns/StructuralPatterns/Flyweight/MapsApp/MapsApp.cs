using DesignPatterns.StructuralPatterns.Flyweight.MapsApp.Point;
using System;

namespace DesignPatterns.StructuralPatterns.Flyweight.MapsApp
{
    public class MapsApp
    {
        public static void Run()
        {
            var service = new PointService(new PointIconFactory());

            Console.WriteLine("Points of Interest:");
            foreach (var point in service.GetPoints())
            {
                point.Draw();
            }
        }
    }
}
