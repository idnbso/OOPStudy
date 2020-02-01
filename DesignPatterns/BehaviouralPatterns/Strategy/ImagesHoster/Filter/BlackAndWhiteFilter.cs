using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.Filter
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine($"Applying B&W Filter for {fileName}");
        }
    }
}
