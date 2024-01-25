using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryStoreApplication
{
    // enum function
    public enum BookingStatus { Default, Initiated, Booked, Cancelled }
    public class BookingDetails
    {
        // Auto-increment ID
        private static int s_bookingID = 3000;

        // property
        public string BookingID { get; }
        public string CustomerID { get; set; }
        public double TotalPrice { get; set; }
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }

        // Constructor
        public BookingDetails(string customerID, double totalPrice, DateTime dateOfBooking, BookingStatus bookingStatus)
        {
            s_bookingID++;
            BookingID = "BID" + s_bookingID;
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking=dateOfBooking;
            BookingStatus = bookingStatus;
        }
    }
}