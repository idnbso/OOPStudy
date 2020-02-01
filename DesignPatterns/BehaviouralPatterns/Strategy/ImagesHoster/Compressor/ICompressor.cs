using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster
{
    public interface ICompressor
    {
        void Compress(string fileName);
    }
}
