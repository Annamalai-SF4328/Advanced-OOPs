using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathLib;

namespace CalculatorApp
{
    public class CircleArea : Class1
    {
        protected double radius;
        public double Radius { get{return radius;} }
        internal double _area { get; set; }
        
        public double CalculateCircleArea(double Radius)
        {
            return PI*Radius*Radius;
        }
    }
}