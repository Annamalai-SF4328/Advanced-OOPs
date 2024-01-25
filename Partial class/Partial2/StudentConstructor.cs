using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, Gender gender, DateTime date, long mobile, double physics, double chemistry,double maths)
        {
            s_studentID++;
            StudentID="SID"+s_studentID;
            Name=name;
            Gender=gender;
            DOB=date;
            Mobile=mobile;
            Physics=physics;
            Chemistry=chemistry;
            Maths=maths;
        }
    }
}