using System;
using MultiLevel1;
namespace Multiple1;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal = new PersonalInfo("Abcd",Gender.Male,new DateTime(2002,11,11),123456789,MaritialStatus.Single);
        System.Console.WriteLine("Personal Info class : \n"+personal.ShowInfo());

        RegisterPerson register = new RegisterPerson("dcba",Gender.Female,new DateTime(2002,12,12),9876546789,MaritialStatus.Married,DateTime.Now,"EFGH","ijkl","No. : 1, chetpet, chennai-600002",3);
        System.Console.WriteLine("\n\nRegister person class : \n"+register.ShowInfo());
    }
}