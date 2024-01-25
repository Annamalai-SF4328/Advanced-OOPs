using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract2
{
    public class MaruthiSwift : Car
    {
        
        public MaruthiSwift(EngineType engine,int seatsCount,double price,CarType carType)
        {
            EngineType=engine;
            SeatsCount=seatsCount;
            Price=price;
            CarType=carType;
        }
        public override string GetCarType()
        {
            return CarType.ToString();
        }

        public override string GetEngineType()
        {
            return EngineType.ToString();
        }

        public override double GetPrice()
        {
            return Price;
        }

        public override int GetSeats()
        {
            return SeatsCount;
        }
    }
}