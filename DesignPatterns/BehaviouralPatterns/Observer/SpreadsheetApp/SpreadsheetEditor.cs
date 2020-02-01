using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp
{
    public class SpreadsheetEditor
    {
        public static void Run()
        {
            var dataSource = new DataSource();
            var pieChart = new Chart("Pie", dataSource);            
            var barChart = new Chart("Bar", dataSource);

            var mainSpreadsheet = new Spreadsheet("Main", dataSource);
            var secondarySpreadsheet = new Spreadsheet("Secondary", dataSource);

            dataSource.AddObserver(mainSpreadsheet);
            dataSource.AddObserver(secondarySpreadsheet);
            dataSource.AddObserver(barChart);
            dataSource.AddObserver(pieChart);

            dataSource.Value = 42;
        }
    }
}
