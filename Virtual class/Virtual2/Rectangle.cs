using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Rectangle : Dimension
    {
        public double Length { get; set; }
        
        public double Height { get; set; }

        public override double Calculate(double Length, double Height)
        {
            Area=Length*Height;
            return Area;
        }
    }
}