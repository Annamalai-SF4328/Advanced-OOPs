using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier1
{
    public class PrincipalInfo : PersonalInfo
    {
        private static int s_principalID=4000;

        public string PrincipalID { get; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }
        
        public PrincipalInfo(string name, string fatherName, DateTime dob, long phone, Gender gender, string mail,string userID,string qualification,int yearOfExperience,DateTime date) : base(name, fatherName, dob, phone, gender, mail, userID)
        {
            s_principalID++;
            PrincipalID="PID"+s_principalID;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=date;
        }
    }
}