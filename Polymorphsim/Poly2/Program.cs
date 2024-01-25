using System;
namespace Poly2;
class Program
{
    public static void Main(string[] args)
    {
        Square square = new Square();
        System.Console.WriteLine("int Square : "+square.Calculate(2));
        System.Console.WriteLine("float Square : "+square.Calculate(2.5));
        System.Console.WriteLine("double Square : "+square.Calculate(3.44));
        System.Console.WriteLine("long Square : "+square.Calculate(200000001300));
    }
}