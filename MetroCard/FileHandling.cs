using System;
using System.IO;

namespace MetroCard
{
    public class FileHandling
    {
        //Create Folder
        public static void Create()
        {
            if (!Directory.Exists("MetroCard"))
            {
                Directory.CreateDirectory("MetroCard");
            }

            if (!File.Exists("MetroCard/TicketFairDetails.csv"))
            {
                File.Create("MetroCard/TicketFairDetails.csv").Close();
            }
            if (!File.Exists("MetroCard/TravelDetails.csv"))
            {
                File.Create("MetroCard/TravelDetails.csv").Close();
            }
            if (!File.Exists("MetroCard/UserDetails.csv"))
            {
                File.Create("MetroCard/UserDetails.csv").Close();
            }
        }
        public static void WriteToCSV()
        {
            //user
            string[] user = new string[Operations.userDetailsList.Count];
            for (int i = 0; i < Operations.userDetailsList.Count; i++)
            {
                user[i] = Operations.userDetailsList[i].CardNumber + "," + Operations.userDetailsList[i].UserName + "," + Operations.userDetailsList[i].PhoneNumber + "," + Operations.userDetailsList[i].Balance;
            }
            File.WriteAllLines("MetroCard/UserDetails.csv", user);
            //ticket
            string[] ticket = new string[Operations.ticketFairDetails.Count];
            for (int i = 0; i < Operations.ticketFairDetails.Count; i++)
            {
                ticket[i] = Operations.ticketFairDetails[i].TicketID + "," + Operations.ticketFairDetails[i].FromLocation + "," + Operations.ticketFairDetails[i].ToLocation + "," + Operations.ticketFairDetails[i].TicketPrice;

            }
            File.WriteAllLines("MetroCard/TicketFairDetails", ticket);
            //travel
            string[] travel = new string[Operations.travelHistory.Count];
            for (int i = 0; i < Operations.travelHistory.Count; i++)
            {
                travel[i] = Operations.travelHistory[i].TravelID + "," + Operations.travelHistory[i].CardNumber + "," + Operations.travelHistory[i].FromLocation + "," + Operations.travelHistory[i].ToLocation + "," + Operations.travelHistory[i].Date.ToString("dd/MM/yyyy") + "," + Operations.travelHistory[i].TravelCost;
            }
            File.WriteAllLines("MetroCard/TravelDetails", travel);



        }
        public static void ReadFromCSV()
        {
            string[] users = File.ReadAllLines("MetroCard/UserDetails.csv");
            foreach (string user in users)
            {
                UserDetails userdetail = new UserDetails(user);
                Operations.userDetailsList.Add(userdetail);
            }
            string[] tickets = File.ReadAllLines("MetroCard/TicketFairDetails");
            foreach (string ticket in tickets)
            {
                TicketFairDetails ticketFair = new TicketFairDetails(ticket);
                Operations.ticketFairDetails.Add(ticketFair);
            }

            string[] travel = File.ReadAllLines("MetroCard/TravelDetails");
            foreach (string travels in travel)
            {
                TravelDetails travelDetail = new TravelDetails(travels);
                Operations.travelHistory.Add(travelDetail);
            }

        }
    }
}
