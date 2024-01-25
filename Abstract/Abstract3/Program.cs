using System;
namespace Abstract2;
class Program
{
    public static void Main(string[] args)
    {
        MaruthiSwift maruthi = new MaruthiSwift(EngineType.Petrol,5,200000,CarType.Hatchback);
        
        System.Console.WriteLine("\nMaruthi Swift\nWheels : "+maruthi.Wheels);
        System.Console.WriteLine("Doors : "+maruthi.Doors);
        System.Console.WriteLine("Engine Type : "+maruthi.EngineType);
        System.Console.WriteLine("Seat count : "+maruthi.SeatsCount);
        System.Console.WriteLine("Price : "+maruthi.Price);
        System.Console.WriteLine("Car type : "+maruthi.CarType);

        SusukiCiaz susuki = new SusukiCiaz(EngineType.Diesel,4,250000,CarType.Sedan);
        
        System.Console.WriteLine("\n\nSusuki Ciaz\nWheels : "+susuki.Wheels);
        System.Console.WriteLine("Doors : "+susuki.Doors);
        System.Console.WriteLine("Engine Type : "+susuki.EngineType);
        System.Console.WriteLine("Seat count : "+susuki.SeatsCount);
        System.Console.WriteLine("Price : "+susuki.Price);
        System.Console.WriteLine("Car type : "+susuki.CarType);
    }
}