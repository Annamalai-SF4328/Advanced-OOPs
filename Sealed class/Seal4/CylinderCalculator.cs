using System;

namespace Seal4
{
    public class CylinderCalculator : Calculator
    {
        public override double Radius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double Areavalue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override double VolumeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public CylinderCalculator(double radius)
        {
            Radius = radius;

        }
        public override void Area()
        {
            Areavalue = 3.14 * Radius * Radius;
        }

        public override void Volume()
        {

        }
    }
}
