using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Sphere : Dimension
    {
        public double Radius { get; set; }

        public override double Calculate(double Radius)
        {
            Area=4*3.14*Radius*Radius;
            return Area;
        }
    }
}