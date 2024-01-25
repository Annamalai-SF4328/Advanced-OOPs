using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual1
{
    public class AreaCalculator
    {
        // Property
        public double Radius { get; set; }
        public double Area { get; set; }
        
        // Method
        public virtual void Calculate(double Radius)
        {
            Area=3.14*Radius*Radius;
        }

        public virtual double Display()
        {
            return Area;
        }
    }
}