using DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster
{
    public class ImageStorage
    {
        public void Store(string fileName, ICompressor compressor, IFilter filter)
        {
            compressor.Compress(fileName);
            filter.Filter(fileName);
        }
    }
}
