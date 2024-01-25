using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier3
{
    public class Suzuki : CarInfo
    {
        private static int s_carModelNumber=3000;

        public string CarModelNumber { get; set; }
        public string CarModelName { get; set; }

        public Suzuki(long engineNumber, long chasisNumber, double tankCapacity, int numberOfSeats, int numberOfKmDriven, DateTime date, string carModelName) : base(engineNumber, chasisNumber, tankCapacity, numberOfSeats, numberOfKmDriven, date)
        {
            s_carModelNumber++;
            CarModelNumber="Suzuki"+s_carModelNumber;
            CarModelName=carModelName;
        }
    }
}