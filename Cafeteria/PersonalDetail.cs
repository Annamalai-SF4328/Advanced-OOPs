using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    // enum
    public enum Gender{Select, Male, Female, Transgender}
    public class PersonalDetail
    {
        // property
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public long Mobile { get; set; }
        public string MailID { get; set; }

        // Constructor
        public PersonalDetail(string name, string fatherName, Gender gender,long mobile, string mailID)
        {
            Name=name;
            FatherName=fatherName;
            Mobile=mobile;
            Gender=gender;
            MailID=mailID;
        }
    }
}