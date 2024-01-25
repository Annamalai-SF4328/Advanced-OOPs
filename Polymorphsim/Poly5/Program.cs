using System;
namespace Poly5;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("Annamalai", "Saravanan", 987654312, Gender.Male);
        SalaryInfo salary1 = new SalaryInfo(employee.EmployeeID, employee.Name, employee.FatherName, employee.MobileNumber, employee.Gender, 28);
        Console.WriteLine($"EmployeeId : {employee.EmployeeID}\nName : {salary1.Name}\nFatherName : {salary1.FatherName}\nMobile : {salary1.MobileNumber}\nGender : {salary1.Gender}\nNumber of Working Days : {salary1.NumberOfDaysWorked}\nSalary : {salary1.Salary}");
    }
}
