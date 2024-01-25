using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public class Syncfusion : FreeLancer
    {
        private static int s_employeeID=1000;
        public string EmployeeID { get; }
        public string WorkLocation { get; set; }
        
        public Syncfusion(string name,string fatherName,Gender gender,string qualification,string role,int workingDays)
        {
            s_employeeID++;
            EmployeeID="SF"+s_employeeID;
            Name=name;
            FatherName=fatherName;
            Gender=gender;
            Qualification=qualification;
            Role=role;
            NoOfWorkingDays=workingDays;
        }

        public override void CalculateSalary()
        {
            base.CalculateSalary();
        }
    }
}