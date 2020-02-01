using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Strategy.ImagesHoster.Filter
{
    public interface IFilter
    {
        void Filter(string fileName);
    }
}
