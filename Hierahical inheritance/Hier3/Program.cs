using System;
using System.Collections.Generic;
using System.Globalization;
namespace Hier3;
class Program
{
    static List<Tata> tataList = new List<Tata>();
    static List<Suzuki> suzukiList = new List<Suzuki>();
    public static void Main(string[] args)
    {
        Tata tata1 = new Tata(1234,98456,20,4,200,new DateTime(2023,12,15),"Tata 123");
        Tata tata2 = new Tata(1111,99996,25,5,400,new DateTime(2024,01,01),"Tata 124");

        Suzuki suzuki1 =new Suzuki(8888,777777,15,5,300,new DateTime(2023,10,02),"Suzuki 001");
        Suzuki suzuki2 =new Suzuki(2222,755577,20,5,600,new DateTime(2024,05,29),"Suzuki 002");

        tataList.Add(tata1);
        tataList.Add(tata2);

        suzukiList.Add(suzuki1);
        suzukiList.Add(suzuki2);

        System.Console.WriteLine("\nTata Cars\n");
        foreach(Tata tata in tataList)
        {
            System.Console.WriteLine("\nCar Model Number : "+tata.CarModelNumber);
            System.Console.WriteLine("Car Model Name : "+tata.CarModelName);
            System.Console.WriteLine("\nCar RC book number : "+tata.RCBookNumber);
            System.Console.WriteLine("Engine Number : "+tata.EngineNumber);
            System.Console.WriteLine("Chasis Number : "+tata.ChasisNumber);
            System.Console.WriteLine("Tank Capacity : "+tata.TankCapacity);
            System.Console.WriteLine("Number Of Seats : "+tata.NumberOfSeats);
            System.Console.WriteLine("Number Of KM Driven : "+tata.NumberOfKmDriven);
            System.Console.WriteLine("Date Of Purchase : "+tata.DateOfPurchase);
            tata.CalculateMilage();
            System.Console.WriteLine("Milage : "+tata.Milage);
        } 


        System.Console.WriteLine("\n\nSuzuki cars\n\n");
        foreach(Suzuki suzuki in suzukiList)
        {
            System.Console.WriteLine("\nCar Model Number : "+suzuki.CarModelNumber);
            System.Console.WriteLine("Car Model Name : "+suzuki.CarModelName);
            System.Console.WriteLine("\nCar RC book number : "+suzuki.RCBookNumber);
            System.Console.WriteLine("Engine Number : "+suzuki.EngineNumber);
            System.Console.WriteLine("Chasis Number : "+suzuki.ChasisNumber);
            System.Console.WriteLine("Tank Capacity : "+suzuki.TankCapacity);
            System.Console.WriteLine("Number Of Seats : "+suzuki.NumberOfSeats);
            System.Console.WriteLine("Number Of KM Driven : "+suzuki.NumberOfKmDriven);
            System.Console.WriteLine("Date Of Purchase : "+suzuki.DateOfPurchase);
            suzuki.CalculateMilage();
            System.Console.WriteLine("Milage : "+suzuki.Milage);
        }     
    }
}