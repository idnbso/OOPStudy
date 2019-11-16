using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo.AccountStates
{
    class FrozenAccount : IAccountState
    {
        private Action OnUnfreeze { get; }

        public FrozenAccount(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        IAccountState IAccountState.Deposit(Action addToBalance)
        {
            this.OnUnfreeze();
            addToBalance();
            return new ActiveAccount(this.OnUnfreeze);
        }

        IAccountState IAccountState.Freeze() => this;
        IAccountState IAccountState.Withdraw(Action subtractFromBalance)
        {
            this.OnUnfreeze();
            subtractFromBalance();
            return new ActiveAccount(this.OnUnfreeze);
        }

        public IAccountState HolderVerified()
        {
            throw new NotImplementedException();
        }

        public IAccountState Close()
        {
            throw new NotImplementedException();
        }
    }
}
