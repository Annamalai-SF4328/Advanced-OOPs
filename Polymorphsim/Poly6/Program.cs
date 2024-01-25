using System;
namespace Poly6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank sbi = new SBI();
            Bank icici = new ICICI();
            Bank hdfc = new HDFC();
            Bank idbi = new IDBI();
            Console.WriteLine($"SBI intrest : {sbi.GetIntrestInfo}");
            Console.WriteLine($"ICICI intrest : {icici.GetIntrestInfo}");
            Console.WriteLine($"HDFC intrest : {hdfc.GetIntrestInfo}");
            Console.WriteLine($"IDBI intrest : {idbi.GetIntrestInfo}");

        }
    }
}