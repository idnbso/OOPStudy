using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp
{
    public class Spreadsheet : IObserver
    {
        public string Name { get; set; }
        private DataSource dataSource;

        public Spreadsheet(string name, DataSource dataSource) : this(name)
        {
            this.dataSource = dataSource;
        }

        public Spreadsheet(string name)
        {
            Name = name;
        }

        public void Update()
        {
            Console.WriteLine($"Spreadsheet {Name} is now displaying new data source value: {dataSource.Value}");
        }
    }
}
