using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SInheri1
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        // Auto Increment ID
        private static int s_userID=1000;
        
        // Property
        public string Name { get; set; }
        public string UserID { get; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        // constructor
        public PersonalInfo(string name, string fatherName,long phone,string mail,DateTime dob, Gender gender)
        {
            s_userID++;
            UserID="UID"+s_userID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
        public PersonalInfo(string name, string fatherName,long phone,string mail,DateTime dob, Gender gender,string userID)
        {
            UserID=userID;
            Name=name;
            FatherName=fatherName;
            Phone=phone;
            Mail=mail;
            DOB=dob;
            Gender=gender;
        }
    }
}