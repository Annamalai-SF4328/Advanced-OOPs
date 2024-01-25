using System;
namespace OnlineLibrary;
class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department =new DepartmentDetails("ECE","BE");
        System.Console.WriteLine("\nBase class\n\nDep. ID : "+department.DepartmentID);
        System.Console.WriteLine("Degree : "+department.Degree);
        System.Console.WriteLine("Dep. Name : "+department.DepartmentName);

        BookInfo book = new BookInfo(department.DepartmentName,department.Degree,department.DepartmentID,"C language","W3 School",200);
        System.Console.WriteLine("\nDerived class\n\nDep. ID : "+book.DepartmentID);
        System.Console.WriteLine("Degree : "+book.Degree);
        System.Console.WriteLine("Dep. Name : "+book.DepartmentName);
        System.Console.WriteLine("\nBook ID : "+book.BookID);
        System.Console.WriteLine("Book Name : "+book.BookName);
        System.Console.WriteLine("Authour Name : "+book.AuthourName);
        System.Console.WriteLine("Price : "+book.Price);

        DepartmentDetails department1 =new DepartmentDetails("ECE","BE");
        System.Console.WriteLine("\nBase class\n\nDep. ID : "+department1.DepartmentID);
        System.Console.WriteLine("Degree : "+department1.Degree);
        System.Console.WriteLine("Dep. Name : "+department1.DepartmentName);
    }
}