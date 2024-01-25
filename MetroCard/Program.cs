using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MetroCard
{
    class Program
    {
        //List details for the user travel and details
     
        public static void Main(string[] args)
        {
            // Operations.DefaultInfo();
            // FileHandling.Create();
            FileHandling.ReadFromCSV();
            Operations.MainMenu();
            FileHandling.WriteToCSV();
           

        }
    }
}