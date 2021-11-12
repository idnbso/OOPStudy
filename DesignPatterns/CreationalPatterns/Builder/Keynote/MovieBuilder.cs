using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class MovieBuilder : IPresentationBuilder
    {
        public Movie Movie { get; private set; }

        public MovieBuilder()
        {
            Movie = new Movie();
        }

        public void AddSlide(Slide slide)
        {
            Movie.AddFrame(slide.Text, duration: 3);
        }
    }
}
