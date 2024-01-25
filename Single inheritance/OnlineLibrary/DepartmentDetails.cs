using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class DepartmentDetails
    {
        // Auto increment ID
        private static int s_departmentID=1000;

        // property
        public string DepartmentID { get; }
        public string DepartmentName { get; set; }
        public string Degree { get; set; }

        // constructor
        public DepartmentDetails(string departmentName,string degree)
        {
            s_departmentID++;
            DepartmentID="DID"+s_departmentID;
            DepartmentName=departmentName;
            Degree=degree;
        }
        public DepartmentDetails(string departmentName,string degree,string departmentID)
        {
            DepartmentID=departmentID;
            DepartmentName=departmentName;
            Degree=degree;
        }

    }
}