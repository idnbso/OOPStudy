using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class Movie
    {
        public void AddFrame(string text, int duration)
        {
            Console.WriteLine($"Adding a frame to the movie with {text} for a duration of {duration} seconds.");
        }
    }
}
