using System;
using System.Collections.Generic;
namespace MultiLevel2;
class Program
{
    static List<BookInfo> books = new List<BookInfo>();
    public static void Main(string[] args)
    {
        BookInfo book1 = new BookInfo("ECE","BE",5,10,"c102","C language","W3 school",200);
        BookInfo book2 = new BookInfo("CSE","BE",2,6,"c103","Jave language","Java point",300);
        BookInfo book3 = new BookInfo("MCA","BE",4,7,"c112","C# language","Syncfusion",500);

        books.Add(book1);
        books.Add(book2);
        books.Add(book3);

        DisplayInfo();
    }

    public static void DisplayInfo()
    {
        foreach(BookInfo book in books)
        {
            System.Console.WriteLine("\nDegree : "+book.Degree);
            System.Console.WriteLine("Department Name : "+book.DepartmentName);
            System.Console.WriteLine("Rack number : "+book.RackNumber);
            System.Console.WriteLine("Column no. : "+book.ColumnNumber);
            System.Console.WriteLine("Book ID : "+book.BookID);
            System.Console.WriteLine("Book name : "+book.BookName);
            System.Console.WriteLine("Authour name : "+book.AuthorName);
            System.Console.WriteLine("Price : "+book.Price);
            
        }
    }
}