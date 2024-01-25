using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public enum AccountType{Select, Savings, Balance}
    public class SavingsAccount : IDInfo, ICalculate, IBankInfo
    {
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string BranchName { get; set; }
        public string AccountNumber { get; set; }
        public AccountType AccountType { get; set; }
        private static double _balance;
        public double Balance { get{return _balance;}}
        
        public SavingsAccount(string name, Gender gender,DateTime dob,long phone,string voterID,string aadharID,string pANNumber,string bankName,string iFSC,string branchName,string accountNumber,AccountType accountType)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Mobile=phone;
            VoterID=voterID;
            AadharID=aadharID;
            PANNumber=pANNumber;
            BankName=bankName;
            IFSC=iFSC;
            BranchName=branchName;
            AccountNumber=accountNumber;
            AccountType=accountType;
            _balance=0;
        }
        
        public double BalanceCheck()
        {
            return Balance;
        }

        public void Deposit(double amount)
        {
            _balance+=amount;
        }

        public void Withdraw(double amount)
        {
            if(_balance>=amount)
            {
                _balance-=amount;
            }
        }
    }
}