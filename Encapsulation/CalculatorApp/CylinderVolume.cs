using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathLib;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private double _height;
        public double Height { get{return _height;} }
        internal double _volume { get; set; }

        public CylinderVolume(double height)
        {
            _height=height;
        }
        public double CalculateVolume()
        {
            _volume=CalculateCircleArea(2)*Height;
            return _volume;
        }
    }
}