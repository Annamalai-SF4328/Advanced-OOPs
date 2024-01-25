using System;

namespace Poly5
{
    public class SalaryInfo : EmployeeInfo
    {
        public double Salary { get; set; }
        public int NumberOfDaysWorked { get; set; }
        public SalaryInfo(string employeeId, string name, string fatherName, long mobile, Gender gender, int numberofWorkingdays) : base(employeeId, name, fatherName, mobile, gender)
        {
            NumberOfDaysWorked = numberofWorkingdays;
            Salary = NumberOfDaysWorked * 500;
        }
    }
}
