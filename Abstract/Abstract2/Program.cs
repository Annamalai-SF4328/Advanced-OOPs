using System;
namespace Abstract2;
class Program
{
    public static void Main(string[] args)
    {
        EEEDepartment eee = new EEEDepartment("Author1","C language","Publisher1","2023");
        eee.SetBookInfo(5);

        System.Console.WriteLine("Serial number : "+eee.SerialNumber);
        System.Console.WriteLine("Author name : "+eee.AuthorName);
        System.Console.WriteLine("Book name : "+eee.BookName);
        System.Console.WriteLine("Publisher name : "+eee.PublisherName);
        System.Console.WriteLine("Year : "+eee.Year);
        System.Console.WriteLine("Book count : "+eee.BookCount);


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