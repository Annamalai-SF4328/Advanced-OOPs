using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public interface IBalance
    {
        double WalletBalance { get; set; }

        void WalletRecharge(double amount);
        void DeductAmount(double amount);

    }
}