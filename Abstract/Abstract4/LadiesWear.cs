using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract4
{
    public class LadiesWear : Dress
    {
        public override DressType DressType { get{return DressType.LadiesWear;} }
        public override string DressName { get; set; }
        public override double Price { get; set; }
        public override double TotalPrice { get; set; }

        public LadiesWear(string dressName, double price)
        {
            
            DressName=dressName;
            Price=price;
        }

        public override void GetDressInfo()
        {
            TotalPrice=Price-(Price*0.2);
        }
    }
}