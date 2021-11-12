using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class PdfDocument
    {
        public void AddPage(string text)
        {
            Console.WriteLine($"Add a page with {text} to the Pdf Document.");
        }
    }
}
