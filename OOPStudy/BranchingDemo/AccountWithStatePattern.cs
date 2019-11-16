using OOPStudy.BranchingDemo.AccountStates;
using System;

namespace OOPStudy.BranchingDemo
{
    /// <summary>
    /// Account only takes care of the balance and state management.
    /// </summary>
    class AccountWithStatePattern
    {
        public Money Balance { get; private set; }

        private IAccountState State { get; set; }

        public AccountWithStatePattern(Action onUnfreeze) => this.State = new NotVerifiedAccount(onUnfreeze);

        public void Deposit(decimal amount) => this.State = this.State.Deposit(() => this.Balance += amount);

        public void Withdraw(decimal amount) => this.State = this.State.Withdraw(() => this.Balance -= amount);

        public void HolderVerified() => this.State = this.State.HolderVerified();

        public void Close() => this.State = this.State.Close();

        public void Freeze() => this.State = this.State.Freeze();
    }
}
