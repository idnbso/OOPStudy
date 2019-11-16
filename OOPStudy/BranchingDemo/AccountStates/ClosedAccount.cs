using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo.AccountStates
{
    class ClosedAccount : IAccountState
    {
        public IAccountState Close() => this;
        
        public IAccountState Deposit(Action addToBalance) => this;

        public IAccountState Freeze() => this;

        public IAccountState HolderVerified() => this;

        public IAccountState Withdraw(Action subtractFromBalance) => this;
    }
}
