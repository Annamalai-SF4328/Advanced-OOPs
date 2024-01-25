using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SInheri1 
{
    public class StudentInfo : PersonalInfo
    {
        // Aut Increment ID
        private static int s_registrationID=2000;

        // property
        public string RegistrationID { get; }
        public int Standard { get; set; }
        public string Branch { get; set; }
        public int AcadamicYear { get; set; }

        // Constructor
        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender,string userID,int standard,string branch,int academicYear) : base(name, fatherName, phone, mail, dob, gender,userID)
        {
            s_registrationID++;
            RegistrationID="RID"+s_registrationID;
            Standard=standard;
            Branch=branch;
            AcadamicYear=academicYear;
        }
    }
}