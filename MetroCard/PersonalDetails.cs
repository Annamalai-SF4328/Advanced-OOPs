using System;

namespace MetroCard
{
    public class PersonalDetails
    {
      //properties
      public string UserName{get;set;}
      public long PhoneNumber{get;set;}
      public PersonalDetails(string userName,long Phonenumber)
      {
        UserName=userName;
        PhoneNumber=Phonenumber;
      }
      public PersonalDetails(){}
    }
}
