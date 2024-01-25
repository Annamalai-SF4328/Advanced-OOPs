using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Virtual2
{
    public class Dimension
    {
        public double Value1 { get; set; }
        public double Value2 { get; set; }
        public double Area { get; set; }

        public virtual double Calculate(double Value1,double Value2)
        {
            Area=Value1*Value2;
            return Area;
        }
        public virtual double Calculate(double Area)
        {
            return Area;
        }
    }
}