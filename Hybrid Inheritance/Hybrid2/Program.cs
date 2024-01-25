using System;
namespace Hybrid2;
class Program
{
    public static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("abcd",Gender.Female,new DateTime(2023,11,11),9876543210,"VID123456","6465 7867 2334","PAN0908","HDFC","IFSC5656780022","Besant nagar","1234567890",AccountType.Savings);
        System.Console.WriteLine("Your balance is "+savings.Balance);

        System.Console.WriteLine("\nName : "+savings.Name);
        System.Console.WriteLine("Gender : "+savings.Gender);
        System.Console.WriteLine("DOB :"+savings.DOB);
        System.Console.WriteLine("Mobile : "+savings.Mobile);
        System.Console.WriteLine("Voter ID : "+savings.VoterID);
        System.Console.WriteLine("Aadhar Number : "+savings.AadharID);
        System.Console.WriteLine("PAN number : "+savings.PANNumber);
        System.Console.WriteLine("\nBank name : "+savings.BankName);
        System.Console.WriteLine("IFSC code : "+savings.IFSC);
        System.Console.WriteLine("Brance : "+savings.BranchName);

        bool flag=true;
        do
        {
            System.Console.WriteLine("\n1. Balance check,\n2. Deposit,\n3. Withdraw,\n4. Exix\n");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    System.Console.WriteLine("Your balance is "+savings.BalanceCheck());
                    break;
                }
                case 2:
                {
                    System.Console.WriteLine("Enter amount to withdraw : ");
                    double amount = double.Parse(Console.ReadLine());
                    savings.Deposit(amount);
                    System.Console.WriteLine("Your balance is "+savings.BalanceCheck());
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Enter amount to withdraw : ");
                    double amount = double.Parse(Console.ReadLine());
                    savings.Withdraw(amount);
                    System.Console.WriteLine("Your balance is "+savings.BalanceCheck());
                    break;
                }
                case 4:
                {
                    flag=false;
                    System.Console.WriteLine("Exit.");
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid Option.");
                    break;
                }
            }
        }while(flag);
    }
}