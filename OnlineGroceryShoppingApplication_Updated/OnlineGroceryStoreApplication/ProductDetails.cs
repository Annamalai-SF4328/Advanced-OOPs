using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    public class ProductDetails
    {
        // Auto-increment property
        private static int s_productID = 2000;

        // property
        public string ProductID { get; }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        // Constructor
        public ProductDetails(string productName, int quantityAvailable, double pricePerQuantity)
        {
            s_productID++;
            ProductID = "PID" + s_productID;
            ProductName = productName;
            QuantityAvailable = quantityAvailable;
            PricePerQuantity = pricePerQuantity;
        }
    }
}