using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain
{
    class EbookProxy : IEbook
    {
        private IEbook ebook;

        public string FileName { get; set; }

        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }

        public void Show()
        {
            if (ebook is null)
            {
                ebook = new Ebook(FileName);
            }

            ebook.Show();
        }
    }
}
