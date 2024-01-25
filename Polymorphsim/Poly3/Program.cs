using System;
namespace Poly3;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eEE = new EEEDepartment("Author1","C language","Publisher1","2023");
        eEE.SetBookInfo(5);

        System.Console.WriteLine("\n\nSerial number : "+eEE.SerialNumber);
        System.Console.WriteLine("Author name : "+eEE.AuthorName);
        System.Console.WriteLine("Book name : "+eEE.BookName);
        System.Console.WriteLine("Publisher name : "+eEE.PublisherName);
        System.Console.WriteLine("Year : "+eEE.Year);
        System.Console.WriteLine("Book count : "+eEE.BookCount);


        CSEDepartment cse = new CSEDepartment("Author2","C# language","Publisher2","2002");
        cse.SetBookInfo(10);

        System.Console.WriteLine("\n\nSerial number : "+cse.SerialNumber);
        System.Console.WriteLine("Author name : "+cse.AuthorName);
        System.Console.WriteLine("Book name : "+cse.BookName);
        System.Console.WriteLine("Publisher name : "+cse.PublisherName);
        System.Console.WriteLine("Year : "+cse.Year);
        System.Console.WriteLine("Book count : "+cse.BookCount);
    }
}