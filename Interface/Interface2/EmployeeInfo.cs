using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class EmployeeInfo
    {
        private static int s_employeeID = 2000;

        public string EmployeeID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }

        public EmployeeInfo()
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
        }

        public void Display(string name,string fatherName)
        {
            Name=name;
            FatherName=fatherName;
        }
    }
}