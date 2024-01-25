using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public class UserDetails : PersonalDetail, IBalance
    {
        private static int s_userID=1000;
        public string UserID { get; }
        public string WorkStationNumber { get; set; }
        private double _balance;
        public double Balance { get{return _balance;}}

        public UserDetails(string name, string fatherName, Gender gender, long mobile, string mailID,string workStationNumber, double balance) : base(name, fatherName, gender, mobile, mailID)
        {
            s_userID++;
            UserID="SF"+s_userID;
            WorkStationNumber=workStationNumber;
            _balance=balance;
        }

        public double WalletBalance { get{return _balance;}}

        double IBalance.WalletBalance { get; set; }

        public void WalletRecharge(double amount)
        {
            _balance=_balance+amount;
        }

        public void DeductAmount(double amount)
        {
            if(_balance>amount)
            {
                _balance=_balance-amount;
            }
        }
    }
}