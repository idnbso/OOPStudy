using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo.AccountStates
{
    class NotVerifiedAccount : IAccountState
    {
        public Action OnUnfreeze { get; private set; }

        public NotVerifiedAccount(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Close() => new ClosedAccount();

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => new ActiveAccount(this.OnUnfreeze);

        public IAccountState Withdraw(Action subtractFromBalance) => this;
    }
}
