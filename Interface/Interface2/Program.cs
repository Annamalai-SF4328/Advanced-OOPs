using System;
namespace Interface2;

class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo(9876543210);
        student.Display("abcd","efgh");

        System.Console.WriteLine("\nStudent ID : "+student.StudentID);
        System.Console.WriteLine("Name : "+student.Name);
        System.Console.WriteLine("Father Name : "+student.FatherName);
        System.Console.WriteLine("Mobile : "+student.Mobile);

        EmployeeInfo employee = new EmployeeInfo();
        employee.Display("ijkl","mnop");

        System.Console.WriteLine("\nEmployee ID : "+employee.EmployeeID);
        System.Console.WriteLine("Name : "+employee.Name);
        System.Console.WriteLine("Father Name : "+employee.FatherName);
    }
}