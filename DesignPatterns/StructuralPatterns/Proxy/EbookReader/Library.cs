using DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader
{
    class Library
    {
        private Dictionary<string, IEbook> ebooks = new Dictionary<string, IEbook>();

        public void Add(IEbook ebook)
        {
            ebooks.Add(ebook.FileName, ebook);
        }

        public void OpenEbook(string fileName)
        {
            if (ebooks.TryGetValue(fileName, out IEbook ebook)) { ebook.Show(); }
            else { throw new Exception($"Ebook with file name {fileName} not found in the library."); }
        }
    }
}
