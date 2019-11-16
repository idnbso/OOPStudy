using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo
{
    /// <summary>
    /// Requirements:
    /// 1. Money can be deposited at any time.
    /// 2. Money can be withdrawn only after the account owner's identity has been verified.
    /// 3. Account holder can close the account at any time.
    /// 4. Closed acouunt does not allow deposit and withdraw.
    /// 5. Account should be frozen if nto used for some time.
    /// 6. Account will be unfrozen automatically on deposit or withdraw.
    /// 7. Unfreezing the account triggers a custom action.
    /// </summary>
    class AccountWithBranching
    {
        public decimal Balance { get; private set; }
        public bool IsVerified { get; private set; }
        public bool IsClosed { get; private set; }
        public bool IsFrozen { get; private set; }

        private Action OnUnfreeze { get; }

        public AccountWithBranching(Action onUnfreeze)
        {
            this.OnUnfreeze = onUnfreeze;
        }

        public void Deposit(decimal amount)
        {
            if (this.IsClosed)
            {
                return; // Or do something else
            }
            if (this.IsFrozen)
            {
                this.IsFrozen = false;
                this.OnUnfreeze();
            }

            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (!this.IsVerified || this.IsClosed)
            {
                return; // Or do something else
            }
            if (this.IsFrozen)
            {
                this.IsFrozen = false;
                this.OnUnfreeze();
            }

            this.Balance -= amount;
        }

        public void HolderVerified()
        {
            this.IsVerified = true;
        }

        public void Close()
        {
            this.IsClosed = true;
        }

        public void Freeze()
        {
            if (!this.IsVerified || this.IsClosed)
            {
                return; // Or do something else
            }
            this.IsFrozen = true;
        }
    }
}
