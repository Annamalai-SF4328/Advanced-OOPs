using System;
namespace Seal2
{
    class Program
    {
        public static void Main(string[] args)
        {
            PatientInfo patient1 = new PatientInfo("Roja", "kubi", 10, "salem", "fever");
            Console.WriteLine($"PatientId{patient1.PatientId}\nName{patient1.Name}\nFatherName{patient1.FatherName}\nBedNo{patient1.BedNo}\nNAtivePlace{patient1.NativePlace}\nAdmittedFor{patient1.AdmittedFor}");

        }
    }
}