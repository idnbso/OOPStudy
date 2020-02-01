using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp
{
    public class Chart : IObserver
    {
        public string Name { get; set; }
        private DataSource dataSource;

        public Chart(string name, DataSource dataSource) : this(name)
        {
            this.dataSource = dataSource;
        }

        public Chart(string name)
        {
            Name = name;
        }

        public void Update()
        {
            Console.WriteLine($"Chart {Name} is now displaying new data source value: {dataSource.Value}");
        }
    }
}
