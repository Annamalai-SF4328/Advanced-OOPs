using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier2
{
    public class TemporaryEmployee : SalaryInfo
    {
        private static int s_employeeID=3000;

        public string EmployeeID { get; }
        public EmployeeType EmployeeType { get; set; }
        public double DA { get{return BasicSalary*0.15;}  } 
        public double HRA { get{return BasicSalary*0.13;}}
        public double PF { get{return 0;}}
        
        
        public TemporaryEmployee(double basicSalary, string month,string salaryID, EmployeeType employeeType) : base(basicSalary, month, salaryID)
        {
            s_employeeID++;
            EmployeeID="TEID"+s_employeeID;
            EmployeeType=employeeType;
        }
        
        public double CalculateSalary()
        {
            return BasicSalary+DA+HRA-PF;
        }
    }
}