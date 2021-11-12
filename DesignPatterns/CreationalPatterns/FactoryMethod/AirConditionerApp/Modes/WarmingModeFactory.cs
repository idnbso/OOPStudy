using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.AirConditionerApp
{
    public class WarmingModeFactory : AirConditionerModeFactory
    {
        public override IAirConditionerMode Create(double temperature) => new WarmingMode(temperature);
    }
}
