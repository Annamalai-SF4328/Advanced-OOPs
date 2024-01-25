using System;
namespace Poly4;
class Program
{
    public static void Main(string[] args)
    {
        Syncfusion syncfusion = new Syncfusion("Abcd","ABCD",Gender.Male,"ECE","Software Developer",30);
        syncfusion.CalculateSalary();

        System.Console.WriteLine("\nName : "+syncfusion.Name);
        System.Console.WriteLine("Father name : "+syncfusion.FatherName);
        System.Console.WriteLine("Gender : "+syncfusion.Gender);
        System.Console.WriteLine("Qualification : "+syncfusion.Qualification);
        System.Console.WriteLine("Role : "+syncfusion.Role);
        System.Console.WriteLine("Working days : "+syncfusion.NoOfWorkingDays);
        System.Console.WriteLine("\nSalary : "+syncfusion.SalaryAmount);
    }
}