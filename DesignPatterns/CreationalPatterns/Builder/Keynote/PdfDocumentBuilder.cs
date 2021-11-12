using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Builder.Keynote
{
    class PdfDocumentBuilder : IPresentationBuilder
    {
        public PdfDocument PdfDocument { get; private set; }

        public PdfDocumentBuilder()
        {
            PdfDocument = new PdfDocument();
        }

        public void AddSlide(Slide slide)
        {
            PdfDocument.AddPage(slide.Text);
        }
    }
}
