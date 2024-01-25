using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class CustomerRegistration : PersonalDetails, IBalance
    {
        // Field
        private double _balance;

        // Auto increment
        private static int s_customerID = 1000;

        // Property
        public string CustomerID { get; }

        public double WalletBalance { get { return _balance; } }

        // Constructor
        public CustomerRegistration(double amount, string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailID) : base(name, fatherName, gender, mobile, dob, mailID)
        {
            s_customerID++;
            CustomerID = "CID" + s_customerID;
            _balance=amount;
        }

        public void WalletRecharge(double amount)
        {
            _balance += amount;
        }

        public void DeductBalance(double amount)
        {
            _balance -= amount;
        }
    }
}