using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract2
{
    public enum EngineType{Select, Petrol, Diesel, CNG}
    public enum CarType{Select,Hatchback, Sedan,  SUV}
    public abstract class Car
    {
        public int Wheels=4;
        public int Doors=4;
        public EngineType EngineType { get; set; }
        public int SeatsCount { get; set; }
        public double Price { get; set; }
        public CarType CarType { get; set; }
        
        public abstract string GetEngineType();
        public abstract int GetSeats();
        public abstract double GetPrice();
        public abstract string GetCarType();
    }
}