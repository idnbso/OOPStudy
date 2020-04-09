using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain
{
    class LoggingEbookProxy : IEbook
    {
        public string FileName { get; }
        private IEbook ebook;

        public LoggingEbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            if (ebook is null)
            {
                ebook = new Ebook(FileName);
            }

            Console.WriteLine($"Logging ebook with file name: {FileName}");
            ebook.Show();
        }
    }
}
