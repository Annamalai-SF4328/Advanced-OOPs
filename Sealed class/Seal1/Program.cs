using System;
namespace Seal1
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeInfo employee1 = new EmployeeInfo("abcd");
            EmployeeInfo employee2 = new EmployeeInfo("efgh");
            Console.WriteLine($"Emplyee ID {employee1.EmployeeID} Password {employee1.Password}");
            Console.WriteLine($"Emplyee ID {employee2.EmployeeID} Password {employee2.Password}");
            employee1.UpdatePassword("abcd@123");
            Console.WriteLine($"Emplyee ID {employee1.EmployeeID} Password {employee1.Password}");
            employee2.UpdatePassword("efgh@123");
            Console.WriteLine($"Emplyee ID {employee2.EmployeeID} Password {employee2.Password}");
             employee1.UpdateKey(400);
            Console.WriteLine($"Emplyee ID {employee1.EmployeeID} Password {employee1.Password}");
            employee2.UpdateKey(400);
            Console.WriteLine($"Emplyee ID {employee2.EmployeeID} Password {employee2.Password}");
        }
    }
}
