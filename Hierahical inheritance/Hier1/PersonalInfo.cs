using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier1
{
    public enum Gender{Select,Male,Female}
    public class PersonalInfo
    {
        private static int s_userID=1000;
        public string UserID { get; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public Gender Gender { get; set; }
        public string Mail { get; set; }
        public PersonalInfo(string name, string fatherName,DateTime dob,long phone,Gender gender,string mail)
        {
            s_userID++;
            UserID="UID"+s_userID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
        }
        public PersonalInfo(string name, string fatherName,DateTime dob,long phone,Gender gender,string mail, string userID)
        {
            UserID=userID;
            Name=name;
            FatherName=fatherName;
            DOB=dob;
            Phone=phone;
            Gender=gender;
            Mail=mail;
        }
    }
}