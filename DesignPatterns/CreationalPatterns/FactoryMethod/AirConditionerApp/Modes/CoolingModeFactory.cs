using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.AirConditionerApp
{
    public class CoolingModeFactory : AirConditionerModeFactory
    {
        public override IAirConditionerMode Create(double temperature) => new CoolingMode(temperature);
    }
}
