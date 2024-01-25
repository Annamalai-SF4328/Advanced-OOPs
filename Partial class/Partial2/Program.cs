using System;
namespace Partial2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("Abcd",Gender.Male,new DateTime(2032,11,11),9876543210,90,90,80);
        System.Console.WriteLine(student.Display());
        System.Console.WriteLine(student.Calculate());
    }
}