using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public enum DressType{Select, LadiesWear, MensWear, childrenswear}
    public abstract class Dress
    {
        public abstract DressType DressType { get; }
        public abstract string DressName { get; set; }
        public abstract double Price { get; set; }
        public abstract double TotalPrice { get; set; }

        public abstract void GetDressInfo();
    }
}