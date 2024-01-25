using System;

namespace MetroCard
{
    public class TicketFairDetails
    {
        private static int s_ticketId = 100;
        public string TicketID { get; set; }

        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public double TicketPrice { get; set; }
        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            ++s_ticketId;
            TicketID = "TID" + s_ticketId;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }
        public TicketFairDetails(string ticket)
        {
            string[] values = ticket.Split(",");
            TicketID = values[0];
            s_ticketId = int.Parse(values[0].Remove(0, 3));
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = double.Parse(values[3]);

        }

    }
}
