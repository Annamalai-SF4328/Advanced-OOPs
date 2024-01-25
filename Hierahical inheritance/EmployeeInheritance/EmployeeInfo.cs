using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    public enum Gender{select, Male, Female}
    public class EmployeeInfo : SalaryInfo
    {
        private static int s_employeeID=3000;

        public string EmployeeID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Branch { get; set; }
        public List<Attendance> attendanceList { get; set; }

        public EmployeeInfo(string salaryID,int salaryMonth,string name,string fatherName,Gender gender,long mobile,DateTime dob,string branch) : base(salaryID, salaryMonth)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Mobile=mobile;
            DOB=dob;
            Branch=branch;
            attendanceList = new List<Attendance>();
        }
        
        public void LogAttendance(Attendance attendance)
        {
            attendanceList.Add(attendance);
        }
        public double CalculateSalary()
        {
            int days=0;
            foreach(Attendance attendance in attendanceList)
            {
                if(attendance.Date.Month.Equals(SalaryMonth) && attendance.NumberOfHoursWorked >=8)
                {
                    days++;
                }
            }
            return 500*days;
        }
    }
}