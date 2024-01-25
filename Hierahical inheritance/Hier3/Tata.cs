using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier3
{
    public class Tata : CarInfo
    {
        private static int s_carModelNumber=2000;

        public string CarModelNumber { get; set; }
        public string CarModelName { get; set; }

        public Tata(long engineNumber, long chasisNumber, double tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime date, string carModelName) : base(engineNumber, chasisNumber, tankCapacity, numberOfSeats, numberOfKmDriven, date)
        {
            s_carModelNumber++;
            CarModelNumber="Tata"+s_carModelNumber;
            CarModelName=carModelName;
        }
    }
}