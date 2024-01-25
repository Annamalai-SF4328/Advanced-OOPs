using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Partial
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string name, Gender gender, DateTime date,long mobile)
        {
            s_employeeID++;
            EmployeeID="EID"+s_employeeID;
            Name = name;
            Gender=gender;
            DOB=date;
            Mobile=mobile;
        }
    }
}