using System;
namespace Abstract1;
class Program
{
    public static void Main(string[] args)
    {
        Cylinders cylinder = new Cylinders();

        Console.WriteLine("Cylinder area : " + cylinder.CalculateArea(3));
        Console.WriteLine("Cylinder Volume : " + cylinder.CalculateVolume(3));

        Cube cube = new Cube();

        Console.WriteLine("Cube area : " + cube.CalculateArea(3));
        Console.WriteLine("Cube Volume : " + cube.CalculateVolume(3));
    }
}