using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public string Display()
        {
            return "Student ID : "+StudentID+"\nName : "+Name+"\nGender : "+Gender+"\nDOB : "+DOB+"\nMobile : "+Mobile+"\nPhysics Mark : "+Physics+"\nChemistry Mark : "+Chemistry+"\nMaths mark : "+Maths;
        }
        public string Calculate()
        {
            double total = Physics+Chemistry+Maths;
            return "\n\nTotal : "+total+"\nPercetage : "+(total/3);
        }
    }
}