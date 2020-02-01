using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI
{
    public class CustomerService
    {
        private string customerName;

        public CustomerService(string customerName)
        {
            this.customerName = customerName;
        }

        public void AddCustomer()
        {
            Console.WriteLine($"Adding customer to database: {customerName}");
        }
    }
}
