using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract1
{
    public class Cube : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }

        public override double CalculateArea(double PageA)
        {
            return 6 * PageA * PageA;
        }

        public override double CalculateVolume(double PageA)
        {
            return PageA * PageA * PageA;
        }
    }
}