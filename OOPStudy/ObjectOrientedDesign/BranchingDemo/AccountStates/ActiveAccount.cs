using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo.AccountStates
{
    class ActiveAccount : IAccountState
    {
        public Action OnUnfreeze { get; private set; }

        public ActiveAccount(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public IAccountState Deposit(Action addToBalance)
        {
            addToBalance();
            return this;
        }

        public IAccountState Freeze() => new FrozenAccount(this.OnUnfreeze);

        public IAccountState Withdraw(Action subtractFromBalance)
        {
            subtractFromBalance();
            return this;
        }

        public IAccountState HolderVerified() => new NotVerifiedAccount(this.OnUnfreeze);

        public IAccountState Close() => new ClosedAccount();
    }
}
