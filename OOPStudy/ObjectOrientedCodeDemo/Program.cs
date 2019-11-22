using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPStudy.ObjectOrientedCodeDemo
{
    class Program
    {
        static void Demo()
        {
            var controlDigit = ControlDigitAlgorithms
                                .ForAccountingDepartment
                                .GetControlDigit(12345);

            Console.WriteLine(controlDigit);
            Console.ReadLine();
        }
    }
}
