using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }
    }
}
