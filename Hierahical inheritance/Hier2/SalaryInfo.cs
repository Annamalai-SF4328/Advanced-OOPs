using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier2
{
    public class SalaryInfo
    {
        private static int s_salaryID=1000;
        public string SalaryID { get; }
        public double BasicSalary { get; set; }
        public string Month { get; set; }
        
        public SalaryInfo(double basicSalary,string month)
        {
            s_salaryID++;
            SalaryID="SID"+s_salaryID;
            BasicSalary=basicSalary;
            Month=month;
        }
        public SalaryInfo(double basicSalary,string month,string salaryID)
        {
            SalaryID=salaryID;
            BasicSalary=basicSalary;
            Month=month;
        }
    }
}