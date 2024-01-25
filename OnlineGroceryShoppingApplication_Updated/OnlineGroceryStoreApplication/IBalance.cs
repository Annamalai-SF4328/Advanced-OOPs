using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public interface IBalance
    {
        double WalletBalance { get; }
        void WalletRecharge(double amount);
        void DeductBalance(double amount);
    }
}