using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel1
{
    public enum Branch{select, Chennai, Vellore, Arni}
    public class StudentInfo : PersonalInfo
    {
        // property
        public int RegisterNumber { get; set; }
        public int Standard { get; set; }
        public Branch Branch { get; set; }
        public int AcadamicYear { get; set; }

        // constructor
        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, Gender gender, int registerNumber, int standard, Branch branch, int acadamicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            RegisterNumber=registerNumber;
            Standard=standard;
            Branch=branch;
            AcadamicYear=acadamicYear;
        }
        
    }
}