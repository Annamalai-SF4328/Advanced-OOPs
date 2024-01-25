using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Multiple1;

namespace MultiLevel1
{
    public enum Gender{Select, Male, Female}
    public enum MaritialStatus{Select, Single, Married}
    public class PersonalInfo : IShowData
    {
        // property
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Phone { get; set; }
        public MaritialStatus MaritialStatus { get; set; }
        
        // Construction
        public PersonalInfo(string name, Gender gender, DateTime dob, long phone, MaritialStatus maritialStatus)
        {
            Name=name;
            Gender=gender;
            DOB=dob;
            Phone = phone;
            MaritialStatus=maritialStatus;
        }

        public string ShowInfo()
        {
            return "Name : "+Name+"\nGender : "+Gender+"\nDate of Birth : "+DOB+"\nPhone : "+Phone+"\nMaritial status : "+MaritialStatus;
        }
    }
}