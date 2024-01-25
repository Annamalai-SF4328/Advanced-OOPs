using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple2
{
    public class ShiftDezire : Car, IBrand
    {
        private static int s_makingID=1000;

        public string MakingID { get; }
        public long EngineNumber { get; set; }
        public long ChasisNumber { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }

        public ShiftDezire(string fuleType, string color, int numberOfSeats, double tankCapacity, double numberOfKmDriven, long engineNumber, long chasisNumber,string brandName, string modelName) : base(fuleType, color, numberOfSeats, tankCapacity, numberOfKmDriven)
        {
            s_makingID++;
            MakingID="SDMID"+s_makingID;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            BrandName=brandName;
            ModelName=modelName;
        }
    }
}