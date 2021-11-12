using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.BuilderRecursiveGenerics
{
    public class EmployeeBuilderDirector : EmployeeSalaryBuilder<EmployeeBuilderDirector>
    {

        public static EmployeeBuilderDirector NewEmployee => new EmployeeBuilderDirector();
    }
}
