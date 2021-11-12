using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class Slide
    {
        public string Text { get; set; }

        public Slide(string text)
        {
            Text = text;
        }
    }
}
