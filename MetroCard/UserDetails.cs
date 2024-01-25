using System;

namespace MetroCard
{
    public class UserDetails : PersonalDetails, IBalance
    {
        //Fields
        private static int s_cardNumber = 100;

        private static double _balance = 0;

        public string CardNumber { get; set; }
        public double Balance { get { return _balance; } }

        public UserDetails(string userName, long Phonenumber) : base(userName, Phonenumber)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
        }

        public UserDetails(string userName, long Phonenumber, double balance) : base(userName, Phonenumber)
        {
            s_cardNumber++;
            CardNumber = "CMRL" + s_cardNumber;
            _balance=balance;
        }
        public UserDetails(string user)
        {
            string[] values = user.Split(",");
            CardNumber = values[0];
            s_cardNumber = int.Parse(values[0].Remove(0, 4));
            UserName = values[1];
            PhoneNumber = long.Parse(values[2]);
            _balance = double.Parse(values[3]);
        }
        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }

        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }
    }
}
