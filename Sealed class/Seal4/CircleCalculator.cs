using System;

namespace Seal4
{
    public class CircleCalculator : Calculator
    {
        public override double Radius { get; set; }
        public override double Areavalue { get; set; }
        public override double VolumeValue { get; set; }

        public CircleCalculator(double radius)
        {
            Radius = radius;

        }
        public sealed override void Area()
        {
            Areavalue = 3.14 * Radius * Radius;

        }

        public override void Volume()
        {

        }
    }
}
