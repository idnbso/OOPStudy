using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    interface IPresentationBuilder
    {
        void AddSlide(Slide slide);
    }
}
