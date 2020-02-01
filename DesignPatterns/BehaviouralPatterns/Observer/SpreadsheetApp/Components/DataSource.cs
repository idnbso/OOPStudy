using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Observer.SpreadsheetApp
{
    public class DataSource : Subject
    {
        private int _value;
        public int Value 
        {
            get => _value; 
            set 
            { 
                _value = value;
                NotifyObservers();
            } 
        }
    }
}
