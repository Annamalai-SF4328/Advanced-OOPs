using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface2
{
    public class StudentInfo : IDisplayInfo
    {
        private static int s_studentID=1000;
        public string StudentID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public StudentInfo(long mobile)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Mobile=mobile;
        }
        public void Display(string name,string fatherName)
        {
            Name=name;
            FatherName=fatherName;
        }
    }
}


