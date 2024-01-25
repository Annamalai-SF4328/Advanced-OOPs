using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public abstract class Shape
    {
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        public double Radius { get; set; }
        public double Height { get; set; }=7;
        public double Width { get; set; }
        public double PageA { get; set; }

        public abstract double CalculateArea(double abc);
        public abstract double CalculateVolume(double abc);

    }
}