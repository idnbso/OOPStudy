using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI
{
    public class CustomerManagementGUI
    {
        public static void Run()
        {
            var customerService = new CustomerService(customerName: "John Smith");
            var command = new AddCustomerCommand(customerService);
            var button = new Button(command);
            button.Click();

            Console.WriteLine();

            var actionsPalette = new ActionsPalette();
            actionsPalette.RunDefaultImageEnchancement();
        }
    }
}
