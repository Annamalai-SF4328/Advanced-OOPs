using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public interface ICalculate
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double BalanceCheck();
    }
}