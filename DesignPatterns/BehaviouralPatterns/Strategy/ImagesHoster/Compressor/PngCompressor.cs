using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster
{
    public class PngCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine($"Compressing using PNG for {fileName}");
        }
    }
}
