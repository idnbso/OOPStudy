using DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.Filter;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster
{
    public class ImageHosterProgram
    {
        public static void Run()
        {
            var storage = new ImageStorage() ;
            storage.Store(@"c:\test.png", new JpegCompressor(), new BlackAndWhiteFilter());
            storage.Store(@"c:\test.png", new PngCompressor(), new HighContrastFilter());
        }
    }
}
