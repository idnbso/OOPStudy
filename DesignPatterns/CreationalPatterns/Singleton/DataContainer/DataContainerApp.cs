﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.Singleton.DataContainer
{
    public class DataContainerApp
    {
        static void Demo(string[] args)
        {
            var db = DataContainerSingleton.Instance;
            Console.WriteLine(db.GetPopulation("Washington, D.C."));
            var db2 = DataContainerSingleton.Instance;
            Console.WriteLine(db.GetPopulation("London"));
        }
    }
}
