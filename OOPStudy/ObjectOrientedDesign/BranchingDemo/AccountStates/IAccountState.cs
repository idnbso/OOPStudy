﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPStudy.BranchingDemo
{
    interface IAccountState
    {
        IAccountState Deposit(Action addToBalance);
        IAccountState Withdraw(Action subtractFromBalance);
        IAccountState Freeze();
        IAccountState HolderVerified();
        IAccountState Close();
    }
}
