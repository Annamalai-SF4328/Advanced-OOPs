using System;
namespace Partial;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("ABCD",Gender.Male,new DateTime(2023,11,11), 9876543210);

        System.Console.WriteLine(employee.Display());
    }
}