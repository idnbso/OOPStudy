﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CoolingMode : IAirConditionerMode
    {
        private readonly double _temperature;

        public CoolingMode(double temperature)
        {
            _temperature = temperature;
        }

        public void Operate()
        {
            Console.WriteLine($"Cooling the room to the required temperature of {_temperature} degrees");
        }
    }
}
