using DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader
{
    public class EbookReaderApp
    {
        public static void Run()
        {
            var library = new Library();
            var fileNames = new List<string>(){ "a", "b", "c" };
            
            fileNames.ForEach(fn => library.Add(new LoggingEbookProxy(fn)));

            library.OpenEbook(fileName: "a");
        }
    }
}
