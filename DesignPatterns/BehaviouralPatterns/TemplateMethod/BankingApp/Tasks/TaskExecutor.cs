using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.BehaviouralPatterns.TemplateMethod.BankingApp.Tasks
{
    public class TaskExecutor
    {
        private readonly AuditTrail auditTrail;
        private readonly ITask task;

        public TaskExecutor(AuditTrail auditTrail, ITask task)
        {
            this.auditTrail = auditTrail;
            this.task = task;
        }

        /// <summary>
        /// The Template Method
        /// </summary>
        public void Execute()
        {
            auditTrail.Record(); // non-mandatory lifecycle call since the concrete task classes are public
            task.Execute();
        }
    }
}
