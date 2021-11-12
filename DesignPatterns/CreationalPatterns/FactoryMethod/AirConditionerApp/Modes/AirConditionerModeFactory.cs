using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.AirConditionerApp
{
    public abstract class AirConditionerModeFactory
    {
        public abstract IAirConditionerMode Create(double temperature);
    }
}
