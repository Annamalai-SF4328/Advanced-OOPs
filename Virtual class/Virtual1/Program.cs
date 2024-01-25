using System;
namespace Virtual1;
class Program
{
    public static void Main(string[] args)
    {
        VolumeCalculator volume = new VolumeCalculator();
        volume.Calculate(3);
        System.Console.WriteLine("Volume Class : "+Math.Round(volume.Display(),2));

        AreaCalculator area = new AreaCalculator();

        area.Calculate(3);
        System.Console.WriteLine("Area Class : "+Math.Round(area.Display(),2));
    }
}