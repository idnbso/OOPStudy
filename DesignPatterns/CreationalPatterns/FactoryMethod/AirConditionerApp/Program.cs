using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.FactoryMethod.AirConditionerApp
{
    class Program
    {
        static void Demo(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteMode(AirConditionerMode.Cooling, 22.5)
                .Operate();
        }
    }
}
