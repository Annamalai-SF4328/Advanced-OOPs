using System;

namespace Seal4
{
    public abstract class Calculator
    {
        public abstract double Radius { get; set; }
        public abstract double Areavalue { get; set; }
        public abstract double VolumeValue { get; set; }

        public abstract void Area();
        public abstract void Volume();
    }
}
