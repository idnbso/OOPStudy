using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework;
using DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI.Framework.Command;
using System;

namespace DesignPatterns.BehaviouralPatterns.Command.CustomerManagementGUI
{
    internal class AddCustomerCommand : ICommand
    {
        private CustomerService customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}