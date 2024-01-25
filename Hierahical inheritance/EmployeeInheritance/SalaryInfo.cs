using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    public class SalaryInfo 
    {
        private static int s_salaryID=2000;
        private double _salary;
        public string SalaryID { get; }
        public double SalaryOfMonth { get{return _salary;} }
        public int SalaryMonth { get; set; }

        public SalaryInfo(int salaryMonth)
        {
            s_salaryID++;
            SalaryID="SID"+s_salaryID;
            SalaryMonth=salaryMonth;
        }
        public SalaryInfo(string salaryID,int salaryMonth)
        {
            SalaryID=salaryID;
            SalaryMonth=salaryMonth;
        }
        public void AddSalary(double amount)
        {
            _salary=amount;
        }
    }
}