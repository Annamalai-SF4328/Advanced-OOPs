using System;
namespace Virtual2;
class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        System.Console.WriteLine("Rectangle Area : "+ rectangle.Calculate(2,5));

        Sphere sphere = new Sphere();
        System.Console.WriteLine("Sphere Area : "+ sphere.Calculate(4));
    }
}