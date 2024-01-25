using System;
using System.Collections.Generic;
namespace Hier1
{
    class Program
    {
        static List<PersonalInfo> personalList = new List<PersonalInfo>();
        static List<StudentInfo> studentsList = new List<StudentInfo>();
        static List<Teacher> teachersList = new List<Teacher>();
        static List<PrincipalInfo> principalsList = new List<PrincipalInfo>();

        public static void Main(string[] args)
        {
            PersonalInfo personal1 = new PersonalInfo("abcd","ABCD",new DateTime(2023,12,15),9876543210,Gender.Male,"abcd@gmail.com");
            PersonalInfo personal2 = new PersonalInfo("efgh","EFGH",new DateTime(2003,10,23),9833333210,Gender.Female,"efgh@gmail.com");

            personalList.Add(personal1);
            personalList.Add(personal2);

            PersonalMethod();

            Teacher teacher1 =new Teacher(personal1.Name,personal1.FatherName,personal1.DOB,personal1.Phone,personal1.Gender,personal1.Mail,personal1.UserID,"ECE","Control System","ME",5,new DateTime(2018,11,23));
            Teacher teacher2 =new Teacher(personal2.Name,personal2.FatherName,personal2.DOB,personal2.Phone,personal2.Gender,personal2.Mail,personal2.UserID,"ECE","Signals and System","Ph.D.",6,new DateTime(2017,06,01));

            teachersList.Add(teacher1);
            teachersList.Add(teacher2);

            TeacherMethod();

            StudentInfo student1 = new StudentInfo(personal1.Name,personal1.FatherName,personal1.DOB,personal1.Phone,personal1.Gender,personal1.Mail,personal1.UserID,"BE","ECE",4);
            StudentInfo student2 = new StudentInfo(personal2.Name,personal2.FatherName,personal2.DOB,personal2.Phone,personal2.Gender,personal2.Mail,personal2.UserID,"BE","ECE",6);

            studentsList.Add(student1);
            studentsList.Add(student2);

            StudentMethod();

            PrincipalInfo principal1 = new PrincipalInfo(personal1.Name,personal1.FatherName,personal1.DOB,personal1.Phone,personal1.Gender,personal1.Mail,personal1.UserID,"Ph.D.",15,new DateTime(2008,06,01));
            PrincipalInfo principal2 = new PrincipalInfo(personal2.Name,personal2.FatherName,personal2.DOB,personal2.Phone,personal2.Gender,personal2.Mail,personal2.UserID,"Ph.D.",20,new DateTime(2003,06,01));

            principalsList.Add(principal1);
            principalsList.Add(principal2);

            PrincipalMethod();
        }

        public static void PersonalMethod()
        {
            foreach(PersonalInfo personal in personalList)
            {
                System.Console.WriteLine("\nUser ID : "+personal.UserID);
                System.Console.WriteLine("Name : "+personal.Name);
                System.Console.WriteLine("Father Name : "+personal.FatherName);
                System.Console.WriteLine("DOB : "+personal.DOB);
                System.Console.WriteLine("Phone : "+personal.Phone);
                System.Console.WriteLine("Gender : "+personal.Gender);
                System.Console.WriteLine("Mail : "+personal.Mail);
            }
        }

        public static void TeacherMethod()
        {
            foreach(Teacher teacher in teachersList)
            {
                System.Console.WriteLine("\n\nTeacher Class\nUser ID : "+teacher.UserID);
                System.Console.WriteLine("Name : "+teacher.Name);
                System.Console.WriteLine("Father Name : "+teacher.FatherName);
                System.Console.WriteLine("DOB : "+teacher.DOB);
                System.Console.WriteLine("Phone : "+teacher.Phone);
                System.Console.WriteLine("Gender : "+teacher.Gender);
                System.Console.WriteLine("Mail : "+teacher.Mail);

                System.Console.WriteLine("\nTeacher ID : "+teacher.TeacherID);
                System.Console.WriteLine("Department : "+teacher.Department);
                System.Console.WriteLine("SubjectTeaching : "+teacher.SubjectTeaching);
                System.Console.WriteLine("Qualification : "+teacher.Qualification);
                System.Console.WriteLine("YearOfExperience : "+teacher.YearOfExperience);
                System.Console.WriteLine("DateOfJoining : "+teacher.DateOfJoining);

            }
        }

        public static void StudentMethod()
        {
            foreach(StudentInfo student in studentsList)
            {
                System.Console.WriteLine("\n\nStudent Class\nUser ID : "+student.UserID);
                System.Console.WriteLine("Name : "+student.Name);
                System.Console.WriteLine("Father Name : "+student.FatherName);
                System.Console.WriteLine("DOB : "+student.DOB);
                System.Console.WriteLine("Phone : "+student.Phone);
                System.Console.WriteLine("Gender : "+student.Gender);
                System.Console.WriteLine("Mail : "+student.Mail);

                System.Console.WriteLine("\nStudent ID : "+student.StudentID);
                System.Console.WriteLine("Degree : "+student.Degree);
                System.Console.WriteLine("Department : "+student.Department);
                System.Console.WriteLine("Semester : "+student.Semester);
            }
        }

        public static void PrincipalMethod()
        {
            foreach(PrincipalInfo principal in principalsList)
            {
                System.Console.WriteLine("\n\nPrincipal Class\nUser ID : "+principal.UserID);
                System.Console.WriteLine("Name : "+principal.Name);
                System.Console.WriteLine("Father Name : "+principal.FatherName);
                System.Console.WriteLine("DOB : "+principal.DOB);
                System.Console.WriteLine("Phone : "+principal.Phone);
                System.Console.WriteLine("Gender : "+principal.Gender);
                System.Console.WriteLine("Mail : "+principal.Mail);

                System.Console.WriteLine("\nPrincipal ID : "+principal.PrincipalID);
                System.Console.WriteLine("Qualification : "+principal.Qualification);
                System.Console.WriteLine("YearOfExperience : "+principal.YearOfExperience);
                System.Console.WriteLine("DateOfJoining : "+principal.DateOfJoining);

            }
        }
    }
}