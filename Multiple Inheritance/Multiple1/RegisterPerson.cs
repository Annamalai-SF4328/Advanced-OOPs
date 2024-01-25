using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultiLevel1;

namespace Multiple1
{
    public class RegisterPerson : PersonalInfo,IShowData, IFamilyInfo
    {
        private static int s_registerNumber { get; set; }
        public string RegisterNumber { get;  }
        public DateTime DateOfRegistration { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string HouseAddress { get; set; }
        public int SiblingsCount { get; set; }

        public RegisterPerson(string name, Gender gender, DateTime dob, long phone, MaritialStatus maritialStatus, DateTime date,string fatherName,string motherName, string houseAddress,int siblingsCount) : base(name, gender, dob, phone, maritialStatus)
        {
            s_registerNumber++;
            RegisterNumber="RID"+s_registerNumber;
            DateOfRegistration=date;
            FatherName=fatherName;
            MotherName=motherName;
            HouseAddress=houseAddress;
            SiblingsCount=siblingsCount;
        }

        public string ShowInfo()
        {
            return "Name : "+Name+"\nGender : "+Gender+"\nDate of Birth : "+DOB+"\nPhone : "+Phone+"\nMaritial status : "+MaritialStatus+"\n\nFather name : "+FatherName+"\nMother Name : "+MotherName+"\nHouse Address : "+HouseAddress+"\nNo. of sibiling : "+SiblingsCount;
        }
    }
}