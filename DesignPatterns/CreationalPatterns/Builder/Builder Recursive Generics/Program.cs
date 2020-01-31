using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderRecursiveGenerics
{
    class Program
    {
        static void Demo(string[] args)
        {
            var emp = EmployeeBuilderDirector.NewEmployee
                .SetName("Maks")
                .AtPosition("Software Developer")
                .WithSalary(3500)
                .Build();

            Console.WriteLine(emp);
        }
    }
}
