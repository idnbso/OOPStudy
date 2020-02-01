using DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp.Tasks;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp
{
    public class Bank
    {
        public static void Main()
        {
            var transferMoneyTask = new TaskExecutor(new AuditTrail(), new TransferMoneyTask());
            var generateFinancialReportTask = new TaskExecutor(new AuditTrail(), new GenerateReportTask());

            // Transfer Money
            transferMoneyTask.Execute();

            // Generate Financial Report
            generateFinancialReportTask.Execute();
        }
    }
}
