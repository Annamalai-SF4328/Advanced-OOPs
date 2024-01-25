using System;

namespace MetroCard
{
    public class TravelDetails
    {
        // Property
        private static int s_travelId = 100;
        public string TravelID { get; set; }
        public string CardNumber { get; set; }
        public string FromLocation { get; set; }
        public string ToLocation { get; set; }
        public DateTime Date { get; set; }
        public double TravelCost { get; set; }

        // Constructor
        public TravelDetails(string cardNumber,string fromLocation,string toLocation,DateTime date,double travelCost)
        {
            s_travelId++;
            TravelID="TID"+s_travelId;
            CardNumber=cardNumber;
            FromLocation=fromLocation;
            ToLocation=toLocation;
            Date=date;
            TravelCost=travelCost;
        }
        public TravelDetails(string travels)
        {
            string[] value=travels.Split(",");
            TravelID=value[0];
            s_travelId=int.Parse(value[0].Remove(0,3));
            CardNumber=value[1];
            FromLocation=value[2];
            ToLocation=value[3];
            Date=DateTime.ParseExact(value[4],"dd/MM/yyyy",null);
            TravelCost=double.Parse(value[5]);
        }
    }
}
