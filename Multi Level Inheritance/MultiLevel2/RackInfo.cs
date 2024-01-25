using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class RackInfo : DepartmentDetails
    {
        // property
        public int RackNumber { get; set; }
        public int ColumnNumber { get; set; }
        // constructor
        public RackInfo(string departmentName,string degree,int rackNumber,int columnNumber) : base(departmentName,degree)
        {
            RackNumber=rackNumber;
            ColumnNumber=columnNumber;
        }
    }
}