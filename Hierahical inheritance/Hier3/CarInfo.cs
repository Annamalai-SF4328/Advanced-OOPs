using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hier3
{
    public class CarInfo
    {
        private static int s_rcBookNumber=1000;
        public string RCBookNumber { get; set; }
        public long EngineNumber { get; set; }
        public long ChasisNumber { get; set; }
        private double _milage;
        public double Milage { get{return _milage;} }
        public double TankCapacity { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfKmDriven { get; set; }
        public DateTime DateOfPurchase { get; set; }
        
        public CarInfo(long engineNumber,long chasisNumber,double tankCapacity,int numberOfSeats,int numberOfKmDriven,DateTime date)
        {
            s_rcBookNumber++;
            RCBookNumber="RC"+s_rcBookNumber;
            EngineNumber=engineNumber;
            ChasisNumber=chasisNumber;
            TankCapacity=tankCapacity;
            NumberOfSeats=numberOfSeats;
            NumberOfKmDriven=numberOfKmDriven;
            DateOfPurchase=date;
        }

        public void CalculateMilage()
        {
            _milage= NumberOfKmDriven/TankCapacity;
        }
    }
}