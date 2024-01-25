using System;
namespace EmployeeInheritance;
class Program
{
    public static void Main(string[] args)
    {
        Attendance attendance1 = new Attendance(new DateTime(2023,11,01),8);
        Attendance attendance2 = new Attendance(new DateTime(2023,11,02),8.5);
        Attendance attendance3 = new Attendance(new DateTime(2023,11,03),9);
        Attendance attendance4 = new Attendance(new DateTime(2023,11,04),9.5);
        Attendance attendance5 = new Attendance(new DateTime(2023,11,05),9);

        SalaryInfo salary1 = new SalaryInfo(11);
        SalaryInfo salary2 = new SalaryInfo(11);

        EmployeeInfo employee1 = new EmployeeInfo(salary1.SalaryID,11,"abcd","ABCD",Gender.Male,987654310, new DateTime(1999,07,26),"Chetpet");
        EmployeeInfo employee2 = new EmployeeInfo(salary2.SalaryID,11,"efgh","EFGH",Gender.Female,934556710, new DateTime(1999,11,06),"Chetpet");

        employee1.LogAttendance(attendance1);
        employee1.LogAttendance(attendance2);
        employee1.LogAttendance(attendance3);
        employee1.LogAttendance(attendance4);
        employee1.LogAttendance(attendance5);


        System.Console.WriteLine("\nSalary ID : "+salary1.SalaryID);
        System.Console.WriteLine("Salary Month : "+salary1.SalaryMonth);
        System.Console.WriteLine("Salary : "+salary1.SalaryOfMonth);

        System.Console.WriteLine("\nSalary ID : "+salary2.SalaryID);
        System.Console.WriteLine("Salary Month : "+salary2.SalaryMonth);
        System.Console.WriteLine("Salary : "+salary2.SalaryOfMonth);

        System.Console.WriteLine("\n\nSalary ID : "+employee1.SalaryID);
        System.Console.WriteLine("Month : "+employee1.SalaryMonth);
        System.Console.WriteLine("Salary : "+employee1.SalaryOfMonth);
        System.Console.WriteLine("Employee ID : "+employee1.EmployeeID);
        System.Console.WriteLine("Name : "+employee1.Name);
        System.Console.WriteLine("Father Name : "+employee1.FatherName);
        System.Console.WriteLine("Gender : "+employee1.Gender);
        System.Console.WriteLine("Mobile : "+employee1.Mobile);
        System.Console.WriteLine("DOB : "+employee1.DOB);
        System.Console.WriteLine("Branch : "+employee1.Branch);

        System.Console.WriteLine("\nSalary ID : "+employee2.SalaryID);
        System.Console.WriteLine("Month : "+employee2.SalaryMonth);
        System.Console.WriteLine("Salary : "+employee2.SalaryOfMonth);
        System.Console.WriteLine("Employee ID : "+employee2.EmployeeID);
        System.Console.WriteLine("Name : "+employee2.Name);
        System.Console.WriteLine("Father Name : "+employee2.FatherName);
        System.Console.WriteLine("Gender : "+employee2.Gender);
        System.Console.WriteLine("Mobile : "+employee2.Mobile);
        System.Console.WriteLine("DOB : "+employee2.DOB);
        System.Console.WriteLine("Branch : "+employee2.Branch);

        double amount = employee1.CalculateSalary();
        System.Console.WriteLine("\n\nTotal Salary : "+amount);

        employee1.AddSalary(amount);
        System.Console.WriteLine("\nSalary ID : "+employee1.SalaryID);
        System.Console.WriteLine("Salary : "+employee1.SalaryOfMonth);
        System.Console.WriteLine("Month : "+employee1.SalaryMonth);
        
    }
}