using System;
namespace Seal4
{
    class Program
    {
        public static void Main(string[] args)
        {
            CircleCalculator circle1 = new CircleCalculator(10);
            CylinderCalculator cylinder1 = new CylinderCalculator(20);
            cylinder1.Area();
            Console.WriteLine($"Area of cylinder{cylinder1.Areavalue}");
            circle1.Area();
            Console.WriteLine($"Area of circle{circle1.Areavalue}");
        }
    }
}