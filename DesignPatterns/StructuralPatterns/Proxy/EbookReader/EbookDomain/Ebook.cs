using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain
{
    internal class Ebook : IEbook
    {
        public string FileName { get; private set; }

        public Ebook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine($"Loading the Ebook with file name: {FileName}");
        }

        public void Show()
        {
            Console.WriteLine($"Showing the Ebook with file name: {FileName}");
        }
    }
}
