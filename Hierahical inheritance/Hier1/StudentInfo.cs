using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier1 
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_studentID=2000;
        public string StudentID { get; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }
        public StudentInfo(string name, string fatherName, DateTime dob, long phone, Gender gender, string mail,string userID ,string degree, string department,int semester) : base(name, fatherName, dob, phone,gender, mail,userID)
        {
            s_studentID++;
            StudentID="RID"+s_studentID;
            Degree=degree;
            Department=department;
            Semester=semester;
        }
        
    }
}