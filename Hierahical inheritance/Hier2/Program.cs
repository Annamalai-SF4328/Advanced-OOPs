using System;
namespace Hier2;
class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanent1 = new PermanentEmployee(30000,"10","SID1001",EmployeeType.WFH);
        PermanentEmployee permanent2 = new PermanentEmployee(40000,"12","SID1002",EmployeeType.WFH);
        
        System.Console.WriteLine("\npermanent employee 1 salary : "+permanent1.CalculateSalary());
        System.Console.WriteLine("permanent employee 2 salary : "+permanent2.CalculateSalary());

        TemporaryEmployee temporary1 = new TemporaryEmployee(10000,"09","SID1003",EmployeeType.WFO);
        TemporaryEmployee temporary2 = new TemporaryEmployee(20000,"06","SID1004",EmployeeType.WFO);

        System.Console.WriteLine("\ntemporary employee 1 salary : "+temporary1.CalculateSalary());
        System.Console.WriteLine("temporary employee 2 salary : "+temporary2.CalculateSalary());

    }
}