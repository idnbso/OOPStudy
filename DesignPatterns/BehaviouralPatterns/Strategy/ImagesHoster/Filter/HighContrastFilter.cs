using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.Filter
{
    class HighContrastFilter : IFilter
    {
        public void Filter(string fileName)
        {
            Console.WriteLine($"Applying High Contrast Filter for {fileName}");
        }
    }
}
