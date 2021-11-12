using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class App
    {
        public static void Run()
        {
            var presentation = new Presentation();
            presentation.AddSlide(new Slide("Slide 1"));
            presentation.AddSlide(new Slide("Slide 2"));
            presentation.AddSlide(new Slide("Slide 3"));

            var pdfBuilder = new PdfDocumentBuilder();
            presentation.Export(pdfBuilder);

            var pdfDocument = pdfBuilder.PdfDocument;

            var movieBuilder = new MovieBuilder();
            presentation.Export(movieBuilder);

            var movie = movieBuilder.Movie;
        }
    }
}
