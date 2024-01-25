using System;
using System.Collections.Generic;
namespace SingleInheritance2;
class Program
{
    static AccountInfo currentAccount;
    static List<AccountInfo> accountsList = new List<AccountInfo>();
    public static void Main(string[] args)
    {
        AccountInfo account = new AccountInfo("abcd", "ABCD", 9876543210, "abcd@gmail.com", new DateTime(2003, 10, 12), Gender.Male, 1000);
        AccountInfo account1 = new AccountInfo("efgh", "EFGH", 9674754163, "efgh@gmail.com", new DateTime(2001, 04, 23), Gender.Female, 2000);
        AccountInfo account2 = new AccountInfo("ijkl", "IJKL", 9648236832, "ijkl@gmail.com", new DateTime(2002, 06, 20), Gender.Male, 3000);

        accountsList.Add(account);
        accountsList.Add(account1);
        accountsList.Add(account2);

        ShowAccountInfo();

        Login();
    }
    public static void ShowAccountInfo()
    {
        foreach (AccountInfo account in accountsList)
        {
            Console.WriteLine("\nName : " + account.Name);
            Console.WriteLine("FatherName : " + account.FatherName);
            Console.WriteLine("Phone : " + account.Phone);
            Console.WriteLine("Mail : " + account.Mail);
            Console.WriteLine("DOB : " + account.DOB);
            Console.WriteLine("Gender : " + account.Gender);
            Console.WriteLine("Account Number : " + account.AccountNumber);
            Console.WriteLine("Branch name : " + account.BranchName);
            Console.WriteLine("IFSC code : " + account.IFSCCode);
            Console.WriteLine("Account Balance : " + account.Balance);
        }
    }

    public static void Login()
    {
        bool flag = true;
        System.Console.WriteLine("Enter Account number : ");
        string loginID = Console.ReadLine().ToUpper();
        do
        {
            foreach (AccountInfo account in accountsList)
            {
                if (loginID == account.AccountNumber)
                {
                    currentAccount = account;
                    Console.WriteLine("Menu\n1. Deposit\n2. Withdraw\n3. show balance\n4. Exit");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            {
                                Deposit();
                                break;
                            }
                        case 2:
                            {
                                Withdraw();
                                break;
                            }
                        case 3:
                            {
                                ShowBalance();
                                break;
                            }
                        case 4:
                            {
                                flag = false;
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("Enter valid option.");
                                break;
                            }
                    }
                }
            }
        } while (flag);
    }
    public static void Deposit()
    {
        System.Console.WriteLine("Enter Amount : ");
        double amount = double.Parse(Console.ReadLine());
        foreach (AccountInfo account in accountsList)
        {
            if (currentAccount.AccountNumber == account.AccountNumber)
            {
                Console.WriteLine("\nBalance : " + account.Deposit(amount));
                break;
            }
        }
    }
    public static void Withdraw()
    {
        System.Console.WriteLine("Enter Amount : ");
        double amount = double.Parse(Console.ReadLine());
        foreach (AccountInfo account in accountsList)
        {
            if (currentAccount.AccountNumber == account.AccountNumber)
            {
                Console.WriteLine("\nBalance : " + account.Withdraw(amount));
                break;
            }
        }
    }
    public static void ShowBalance()
    {
        foreach (AccountInfo account in accountsList)
        {
            if (currentAccount.AccountNumber == account.AccountNumber)
            {
                System.Console.WriteLine("\nBalance : " + account.ShowBalance());
                break;
            }
        }
    }
}