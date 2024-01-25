using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public enum Gender { Select, Male, Female }
    public class PersonalDetails
    {
        // property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string MailID { get; set; }

        // Constructor
        public PersonalDetails(string name, string fatherName, Gender gender, long mobile, DateTime dob, string mailID)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            DOB = dob;
            MailID = mailID;
        }
    }
}