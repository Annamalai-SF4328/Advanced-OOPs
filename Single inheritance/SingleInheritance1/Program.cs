using System;
namespace SInheri1;
class Program
{
    public static void Main(string[] args)
    {
        // base class object
        PersonalInfo personal = new PersonalInfo("Annamalai","Saravanan",1233567888,"annamalai@gmail.com",new DateTime(2001,07,27),Gender.Male);
        System.Console.WriteLine("User ID : "+personal.UserID);
        System.Console.WriteLine("Name : "+personal.Name);
        System.Console.WriteLine("Father Name : "+personal.FatherName);
        System.Console.WriteLine("Phone : "+personal.Phone);
        System.Console.WriteLine("Mail : "+personal.Mail);
        System.Console.WriteLine("DOB : "+personal.DOB);
        System.Console.WriteLine("Gender : "+personal.Gender);

        // derived class object
        StudentInfo student = new StudentInfo(personal.Name,personal.FatherName,personal.Phone,personal.Mail,personal.DOB,personal.Gender,personal.UserID,10,"Chennai",2023);
        System.Console.WriteLine("\n\nUser ID : "+student.UserID);
        System.Console.WriteLine("Name : "+student.Name);
        System.Console.WriteLine("Father Name : "+student.FatherName);
        System.Console.WriteLine("Phone : "+student.Phone);
        System.Console.WriteLine("Mail : "+student.Mail);
        System.Console.WriteLine("DOB : "+student.DOB);
        System.Console.WriteLine("Gender : "+student.Gender);
        System.Console.WriteLine("\nRegistretion ID : "+student.RegistrationID);
        System.Console.WriteLine("Standard : "+student.Standard);
        System.Console.WriteLine("Branch : "+student.Branch);
        System.Console.WriteLine("Academic Year : "+student.AcadamicYear);

        PersonalInfo personal1 = new PersonalInfo("Annamalai","Saravanan",1233567888,"annamalai@gmail.com",new DateTime(2001,07,27),Gender.Male);
        System.Console.WriteLine("User ID : "+personal1.UserID);
        System.Console.WriteLine("Name : "+personal1.Name);
        System.Console.WriteLine("Father Name : "+personal1.FatherName);
        System.Console.WriteLine("Phone : "+personal1.Phone);
        System.Console.WriteLine("Mail : "+personal1.Mail);
        System.Console.WriteLine("DOB : "+personal1.DOB);
        System.Console.WriteLine("Gender : "+personal1.Gender);
    }
}