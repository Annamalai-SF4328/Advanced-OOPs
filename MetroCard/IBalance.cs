using System;

namespace MetroCard
{
    public interface IBalance
    {
        //properties
        double Balance { get; }

        //Methods
        void WalletRecharge(double amount);
        void DeductBalance(double amount);

    }
}
