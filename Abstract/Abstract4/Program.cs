using System;
namespace Abstract4;
class Program
{
    public static void Main(string[] args)
    {
        LadiesWear ladies = new LadiesWear("Ladis Dress1",100);

        System.Console.WriteLine("Ladis Wear \nDress Type : "+ladies.DressType);
        System.Console.WriteLine("Dress Name : "+ladies.DressName);
        System.Console.WriteLine("Dress Actual Price : "+ladies.Price);
        ladies.GetDressInfo();
        System.Console.WriteLine("Dress Discount price : "+ladies.TotalPrice);

        MensWear mens = new MensWear("Mens Dress1",200);

        System.Console.WriteLine("\n\nmens Wear \nDress Type : "+mens.DressType);
        System.Console.WriteLine("Dress Name : "+mens.DressName);
        System.Console.WriteLine("Dress Actual Price : "+mens.Price);
        mens.GetDressInfo();
        System.Console.WriteLine("Dress Discount price : "+mens.TotalPrice);
    }
}