using DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp.Tasks
{
    internal class TransferMoneyTask : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Transfer Money");
        }
    }
}
