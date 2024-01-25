using System;

namespace Poly5
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int s_employeeId = 1000;

        public string EmployeeID { get; set; }
        public EmployeeInfo(string name, string fatherName, long mobile, Gender gender)
        {
            EmployeeID = $"EID{++s_employeeId}";
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobile;
        }
        public EmployeeInfo(string employeeId, string name, string fatherName, long mobile, Gender gender)
        {
            EmployeeID = employeeId;
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            MobileNumber = mobile;
        }
    }
}
