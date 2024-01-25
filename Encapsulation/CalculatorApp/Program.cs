using System;
namespace CalculatorApp;
using MathLib;
class Program
{
    public static void Main(string[] args)
    {
        Class1 class1 = new Class1();
        
        System.Console.WriteLine("\nWeight : "+class1.CalculateWeight(2));

        CircleArea circle = new CircleArea();
        
        System.Console.WriteLine("Circle Area : "+circle.CalculateCircleArea(2));

        CylinderVolume cylinder = new CylinderVolume(8);

        System.Console.WriteLine("Cylinder Volume : "+cylinder.CalculateVolume());
    }
}