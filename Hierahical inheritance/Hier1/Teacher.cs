using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Hier1
{
    public class Teacher : PersonalInfo
    {
        private static int s_teacherID=3000;

        public string TeacherID { get; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public Teacher(string name, string fatherName, DateTime dob, long phone, Gender gender, string mail,string userID, string department, string subjectTeaching, string qualification,int yearOfExperience,DateTime date) : base(name, fatherName, dob, phone, gender, mail, userID)
        {
            s_teacherID++;
            TeacherID="TID"+s_teacherID;
            Department=department;
            SubjectTeaching=subjectTeaching;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=date;
        }
    }
}