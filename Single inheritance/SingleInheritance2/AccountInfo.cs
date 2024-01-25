using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance2
{
    public class AccountInfo : PersonalInfo
    {
        // Field
        private static int s_accountNumber = 5000;
        // Property
        public string AccountNumber { get; set; }
        public string BranchName { get; }="Besant Nagar";
        public string IFSCCode { get; } ="HDFC234576";
        public double Balance { get; set; }

        // Constructor
        public AccountInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, double balance) : base(name, fatherName, phone, mail, dob, gender)
        {
            s_accountNumber++;
            AccountNumber="HDFC"+s_accountNumber;
            Balance=balance;
        }

        // Methods
        public double Deposit(double amount)
        {
            Balance += amount;
            return Balance;
        }
        public double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
        public double ShowBalance()
        {
            return Balance;
        }
    }
}