using System;
namespace Poly7;
class Program
{
    public static void Main(string[] args)
    {
        Attendance attendance1 = new Attendance(28,2,1);
        Attendance attendance2 = new Attendance(25,1,4);
        Attendance attendance3 = new Attendance(30,1,0);

        Attendance attendance = attendance1+attendance2+attendance3;
        System.Console.WriteLine("Total working days : "+attendance.TotalWorkingDays);
        System.Console.WriteLine("Leave taken : "+attendance.LeaveTaken);
        System.Console.WriteLine("Permission taken : "+attendance.PermissionTaken);
        System.Console.WriteLine("Salary : "+attendance.CalculateSalary());
    }
}