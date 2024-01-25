using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace MetroCard
{
    public class Operations
    {
        public static List<UserDetails> userDetailsList = new List<UserDetails>();
        public static List<TravelDetails> travelHistory = new List<TravelDetails>();
        public static List<TicketFairDetails> ticketFairDetails = new List<TicketFairDetails>();
        public static UserDetails currentUser;
        public static void MainMenu()
        {
            bool option = true;
            do
            {
                Console.WriteLine("Application for metro management\n1.user Registration\n2. Login user\n3.Exit");
                int menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        {
                            //registration
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            //login
                            LoginUser();
                            break;
                        }
                    case 3:
                        {
                            // exit
                            option = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }

                }

            } while (option);

        }
        public static void Registration()
        {
            Console.WriteLine("\nEnter your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Phone Number : ");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Your balance amount is 0.");
            
            UserDetails users = new UserDetails(name, phoneNumber);
            userDetailsList.Add(users);

            //show the succes message
            Console.WriteLine($"You have registered successfully your card Number is{users.CardNumber} ");

        }
        public static void LoginUser()
        {
            bool checklogin = false;
            Console.WriteLine("Login Page\n Enter your card Number");
            string cardNumber = Console.ReadLine();

            foreach (UserDetails users in userDetailsList)
            {
                if (users.CardNumber == cardNumber.ToUpper())
                {
                    currentUser = users;
                    checklogin = true;
                    SubMenu();
                    break;
                }
            }
            if (!checklogin)
            {
                Console.WriteLine("Invalid User Id/card Number");
            }

        }
        
        public static void SubMenu()
        {
            bool checksubmenu = true;
            do
            {
                Console.WriteLine("SubMenu \n please click the one option below\na. Balance check\nb.Recharge\nc.ViewTravelHistory\nd.Travel\ne.Exit");
                char submenu = char.Parse(Console.ReadLine());
                switch (submenu)
                {
                    case 'a':
                        {
                            //check balance
                            BalanceCheck();
                            break;
                        }
                    case 'b':
                        {
                            //Recharge
                            Recharge();
                            break;
                        }
                    case 'c':
                        {
                            //viewhistory
                            ViewTravelHistory();
                            break;
                        }
                    case 'd':
                        {
                            //Travel
                            Travel();
                            break;
                        }
                    case 'e':
                        {
                            //Exit
                            checksubmenu = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }

                }

            } while (checksubmenu);

        }
        
        public static void BalanceCheck()
        {
            Console.WriteLine($"Your account Balance is {currentUser.Balance}");
        }
        
        public static void Recharge()
        {
            Console.WriteLine("Enter the amount to recharge");
            double amount = double.Parse(Console.ReadLine());
            currentUser.WalletRecharge(amount);
            Console.WriteLine($"You have recharged successfully ,your current balance is{currentUser.Balance}");
        }
        
        public static void ViewTravelHistory()
        {
            Console.WriteLine("Your Travel History");
            foreach (TravelDetails travels in travelHistory)
            {
                Console.WriteLine("TravelId\tCarNuumber\t\tFromLocation\t\tToLocation\t\tDate\t\tTravelCost\t\t");
                if (travels.CardNumber == currentUser.CardNumber)
                {
                    Console.WriteLine($"{travels.TravelID}|{travels.CardNumber}|{travels.FromLocation}|{travels.ToLocation}|{travels.Date.ToString("dd/MM/yyyy", null)}|{travels.TravelCost}");
                }
            }

        }
        
        public static void Travel()
        {
            Console.WriteLine("Ticket Details");
            Console.WriteLine("TicketId\t\tFrom Location\t\tToLocation\t\t\tFair");
            foreach (TicketFairDetails travels in ticketFairDetails)
            {

                Console.WriteLine($"{travels.TicketID}|{travels.FromLocation}|{travels.ToLocation}|{travels.TicketPrice}");

            }
            
            //ask the user ticket id and validate the id
            // if it is avaliable then check the balance
            // if balance is there then reduce the amount fromwallet for ticket price and show the travel id
            bool checkticketid = false;
            Console.WriteLine("Enter the ticket id you want to book");
            string ticketId = Console.ReadLine();
            foreach (TicketFairDetails tickets in ticketFairDetails)
            {
                if (tickets.TicketID == ticketId.ToUpper())
                {
                    if (currentUser.Balance >= tickets.TicketPrice)
                    {
                        currentUser.DeductBalance(tickets.TicketPrice);
                        TravelDetails travel = new TravelDetails(currentUser.CardNumber, tickets.FromLocation, tickets.ToLocation, DateTime.Now, tickets.TicketPrice);
                        travelHistory.Add(travel);
                        Console.WriteLine($"You have booked your travel successfully your travel Id is{travel.TravelID}");
                    }
                    else
                    {
                        Console.WriteLine("Insufficient Balance , Please recharge and try Again");
                    }
                    checkticketid = true;
                    break;
                }
            }
            if (!checkticketid)
            {
                Console.WriteLine("Invalid Id");
            }


        }

        public static void DefaultInfo()
        {
            UserDetails user1 = new UserDetails("Ravi", 994888, 1000);
            UserDetails user2 = new UserDetails("BAskaran", 994883, 1000);

            userDetailsList.Add(user1);
            userDetailsList.Add(user2);

            TravelDetails travel1 = new TravelDetails("CMRL101", "Airport", "Egmore", new DateTime(2022, 10, 10), 55);
            TravelDetails travel2 = new TravelDetails("CMRL101", "Egmore", "Koyambedu", new DateTime(2022, 10, 10), 32);
            TravelDetails travel3 = new TravelDetails("CMRL102", "Alandur", "Koyambedu", new DateTime(2022, 10, 10), 25);
            TravelDetails travel4 = new TravelDetails("CMRL102", "Egmore", "Thirumangalam", new DateTime(2022, 10, 10), 25);

            travelHistory.Add(travel1);
            travelHistory.Add(travel2);
            travelHistory.Add(travel3);
            travelHistory.Add(travel4);

            TicketFairDetails ticket1 = new TicketFairDetails(" Airport", " Egmore ", 55);
            TicketFairDetails ticket2 = new TicketFairDetails(" Airport", "Koyambedu", 25);
            TicketFairDetails ticket3 = new TicketFairDetails(" Alandur ", "Koyambedu", 25);
            TicketFairDetails ticket4 = new TicketFairDetails(" Koyambedu  ", "Egmore", 32);
            TicketFairDetails ticket5 = new TicketFairDetails(" Vadapalani  ", "Egmore", 45);
            TicketFairDetails ticket6 = new TicketFairDetails(" Arumbakkam  ", "Egmore ", 25);
            TicketFairDetails ticket7 = new TicketFairDetails(" Vadapalani ", " Koyambedu ", 25);
            TicketFairDetails ticket8 = new TicketFairDetails(" Arumbakkam", "Koyambedu ", 16);

            ticketFairDetails.Add(ticket1);
            ticketFairDetails.Add(ticket2);
            ticketFairDetails.Add(ticket3);
            ticketFairDetails.Add(ticket4);
            ticketFairDetails.Add(ticket5);
            ticketFairDetails.Add(ticket6);
            ticketFairDetails.Add(ticket7);
            ticketFairDetails.Add(ticket8);
        }
    }

}
