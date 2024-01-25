using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial
{
    public partial class EmployeeInfo
    {
        public string Display()
        {
            return "Employee ID : "+EmployeeID+"\nName : "+Name+"\nGender : "+Gender+"\nDOB : "+DOB+"\nMobile : "+Mobile;
        }
    }
}