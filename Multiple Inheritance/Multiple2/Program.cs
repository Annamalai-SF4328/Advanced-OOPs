using System;
namespace Multiple2;
class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire shift = new ShiftDezire("Petrol","Yellow",5,20,300,876543,456376,"Tata","T001");

        System.Console.WriteLine("\nShift Dezire : \n\nFuel type : "+shift.FuleType);
        System.Console.WriteLine("Color : "+shift.Color);
        System.Console.WriteLine("Seats : "+shift.NumberOfSeats);
        System.Console.WriteLine("Tank capacity : "+shift.TankCapacity);
        System.Console.WriteLine("KM driven : "+shift.NumberOfKmDriven);
        System.Console.WriteLine("Engine number : "+shift.EngineNumber);
        System.Console.WriteLine("Chasis number : "+shift.ChasisNumber);
        System.Console.WriteLine("Brand name : "+shift.BrandName);
        System.Console.WriteLine("Model name : "+shift.ModelName);
        System.Console.WriteLine("\nMilage : "+shift.CalculateMilage());

        Eco eco = new Eco("Decel","Black",4,15,200,873443,457676,"ECO","EcoEco27");

        System.Console.WriteLine("\n\nEco : \n\nFuel type : "+eco.FuleType);
        System.Console.WriteLine("Color : "+eco.Color);
        System.Console.WriteLine("Seats : "+eco.NumberOfSeats);
        System.Console.WriteLine("Tank capacity : "+eco.TankCapacity);
        System.Console.WriteLine("KM driven : "+eco.NumberOfKmDriven);
        System.Console.WriteLine("Engine number : "+eco.EngineNumber);
        System.Console.WriteLine("Chasis number : "+eco.ChasisNumber);
        System.Console.WriteLine("Brand name : "+eco.BrandName);
        System.Console.WriteLine("Model name : "+eco.ModelName);
        System.Console.WriteLine("\nMilage : "+Math.Round(eco.CalculateMilage(),2));
    }
}