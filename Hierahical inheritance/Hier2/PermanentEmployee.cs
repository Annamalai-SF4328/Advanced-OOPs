using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier2
{
    public enum EmployeeType{ select, WFH, WFO }
    public class PermanentEmployee : SalaryInfo
    {
        private static int s_employeeID = 2000;
        public string EmployeeID { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public double DA { get{return BasicSalary*0.2;}  } 
        public double HRA { get{return BasicSalary*0.18;}}
        public double PF { get{return BasicSalary*0.1;}}

        public PermanentEmployee(double basicSalary, string month,string salaryID,EmployeeType employeeType) : base(basicSalary, month,salaryID)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            EmployeeType=employeeType;
        }
        public double CalculateSalary()
        {
            return BasicSalary+DA+HRA-PF;
        }
    }
}