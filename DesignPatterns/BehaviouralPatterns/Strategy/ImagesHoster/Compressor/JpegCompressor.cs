using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster
{
    class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing using JPEG for {fileName}");
        }
    }
}
