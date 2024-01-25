using System;
using System.Collections.Generic;
using SingleInheritance1;
namespace SingleInheritance;
class Program
{
    static List<StudentInfo> studentList = new List<StudentInfo>();
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Annamalai","Saravanan",1234567890,"abcd@gmail.com",DateTime.ParseExact("26/06/2002","dd/MM/yyyy",null),Gender.Male,1234,10,SingleInheritance1.Branch.Arni,2023);
        StudentInfo student1 = new StudentInfo("Anton","Jo",1234567890,"anton@gmail.com",DateTime.ParseExact("12/08/2002","dd/MM/yyyy",null),Gender.Male,1324,10,SingleInheritance1.Branch.Chennai,2023);
        studentList.Add(student);
        studentList.Add(student1);
        ShowStudentInfo();
    }
    public static void ShowStudentInfo()
    {
        foreach(StudentInfo student in studentList)
        {
            Console.WriteLine("\nName : "+student.Name);
            Console.WriteLine("FatherName : "+student.FatherName);
            Console.WriteLine("Phone : "+student.Phone);
            Console.WriteLine("Mail : "+student.Mail);
            Console.WriteLine("DOB : "+student.DOB);
            Console.WriteLine("Gender : "+student.Gender);
            Console.WriteLine("RegisterNumber : "+student.RegisterNumber);
            Console.WriteLine("Standard : "+student.Standard);
            Console.WriteLine("Branch : "+student.Branch);
            Console.WriteLine("AcadamicYear : "+student.AcadamicYear);
        }
    }
}