using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual1
{
    public class VolumeCalculator : AreaCalculator
    {
        // property
        public double Height { get; set; } = 2;

        // Method
        public override void Calculate(double Radius)
        {
            Area=3.14*Radius*Radius*Height;
        }

        public override double Display()
        {
            return base.Display();
        }
    }
}