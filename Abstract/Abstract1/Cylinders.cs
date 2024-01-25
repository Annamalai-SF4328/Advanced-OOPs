using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cylinders : Shape
    {
        public override double CalculateVolume(double Radius)
        {
            return Math.PI * Radius * Radius * Height;
        }

        public override double CalculateArea(double Radius)
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }

        public override double Area { get; set; }
        public override double Volume { get; set; }
    }
}