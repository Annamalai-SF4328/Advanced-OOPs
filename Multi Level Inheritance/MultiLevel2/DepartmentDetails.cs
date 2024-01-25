using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class DepartmentDetails
    {
        // property
        public string DepartmentName { get; set; }
        public string Degree { get; set; }
        // constructor
        public DepartmentDetails(string departmentName,string degree)
        {
            DepartmentName=departmentName;
            Degree=degree;
        }
    }
}