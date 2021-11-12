using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class Presentation
    {
        private readonly IList<Slide> _slides = new List<Slide>();

        public void AddSlide(Slide slide)
        {
            _slides.Add(slide);
        }

        public void Export(IPresentationBuilder builder)
        {
            builder.AddSlide(new Slide("Copyright"));
            foreach (var slide in _slides)
            {
                builder.AddSlide(slide);
            }
        }
    }
}
