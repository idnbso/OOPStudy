using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class SalaryCalculator
    {
        private IDevSalaryCalculator _calculator;

        public SalaryCalculator(IDevSalaryCalculator calculator)
        {
            _calculator = calculator;
        }

        public void SetCalculator(IDevSalaryCalculator calculator) => _calculator = calculator;

        public double Calculate(IEnumerable<DeveloperReport> reports) => _calculator.CalculateTotalSalary(reports);
    }
}
