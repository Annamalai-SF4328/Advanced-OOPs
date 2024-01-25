using System;
using System.Collections.Generic;
namespace Cafeteria;
class Program
{
    static List<UserDetails> usersList = new List<UserDetails>();
    static List<FoodDetails> foodList = new List<FoodDetails>();
    static List<CardItem> cardsList = new List<CardItem>();
    static List<OrderDetails> ordersList = new List<OrderDetails>();
    static UserDetails currentUser;
    static OrderDetails currentOrder;
    public static void Main(string[] args)
    {
        bool flag=true;
        do
        {
            LoadDefaultData();
            System.Console.WriteLine("Main Menu\n1. User Registration\n2. User Login\n3. Exit");
            int choice = int.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                {
                    UserRegistration();
                    break;
                }
                case 2:
                {
                    UserLogin();
                    break;
                }
                case 3:
                {
                    System.Console.WriteLine("Exit");
                    flag=false;
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Invalid choice. Enter valid choice.");
                    break;
                }
            }
        }while(flag);
    }

    public static void UserRegistration()
    {
        // Get the detail from customer
        Console.WriteLine("Enter User Name : ");
        string userName = Console.ReadLine();
        Console.WriteLine("Enter Father Name : ");
        string fatherName = Console.ReadLine();
        Console.WriteLine("Enter Mobile number : ");
        long mobile = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter Gender : ");
        Gender gender=Enum.Parse<Gender>(Console.ReadLine(),true);
        Console.WriteLine("Enter Email ID : ");
        string mailID = Console.ReadLine();
        Console.WriteLine("Enter Workstation number : ");
        string workStationNumber=Console.ReadLine();
        Console.WriteLine("Your balance is zero.");

        // object create
        UserDetails user = new UserDetails(userName,fatherName,gender,mobile,mailID,workStationNumber,0);
        
        // Display user ID
        Console.WriteLine("user ID : "+user.UserID);

        // add to the list
        usersList.Add(user);
    }

    public static void UserLogin()
    {
        // get user ID from user
        Console.WriteLine("Enter user ID : ");
        string loginID = Console.ReadLine().ToUpper();
        
        // validate the user ID from user list
        bool flag= true;
        foreach(UserDetails user in usersList)
        {
            if(loginID==user.UserID)
            {
                currentUser=user;
                flag=false;

                // Display submenu
                SubMenu();
            }
        }
        if(flag)
        {
            Console.WriteLine("Invalid Customer ID");
        }
    }

    public static void SubMenu()
    {
        bool flag = true;
        do
        {
            Console.WriteLine("\nSubmenu \n1. Show My Profile\n2. Food Order\n3. Modify Order\n4. Cancel Order\n5. Order History\n6. Wallet Recharge\n7. Show WalletBalance\n8. Exit");
            int choice1 = int.Parse(Console.ReadLine());
            switch(choice1)
            {
                case 1:
                {
                    ShowMyProfile();
                    break;
                }
                case 2:
                {
                    FoodOrder();
                    break;
                }
                case 3:
                {
                    ModifyOrder();
                    break;
                }
                case 4:
                {
                    CancelOrder();
                    break;
                }
                case 5:
                {
                    OrderHistory();
                    break;
                }
                case 6:
                {
                    WalletRecharge();
                    break;
                }
                case 7:
                {
                    ShowWalletBalance();
                    break;
                }
                case 8:
                {
                    flag=false;
                    System.Console.WriteLine("\nExit from SubMenu\n");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Choice");
                    break;
                }
            }
        }while(flag);
    }

    public static void ShowMyProfile()
    {
        // show current user details
        foreach(UserDetails user in usersList)
        {
            if(currentUser.UserID==user.UserID)
            {
                System.Console.WriteLine("\nUser ID : "+user.UserID);
                System.Console.WriteLine("User Name : "+user.Name);
                System.Console.WriteLine("Father Name : "+user.FatherName);
                System.Console.WriteLine("Mobile Number : "+user.Mobile);
                System.Console.WriteLine("Mail ID : "+user.MailID);
                System.Console.WriteLine("Gender : "+user.Gender);
                System.Console.WriteLine("Work Station Number : "+user.WorkStationNumber);
                System.Console.WriteLine("Balance : "+user.Balance);
            }
        }
    }

    public static void FoodOrder()
    {
        // show Food card
        foreach(FoodDetails food in foodList)
        {
            System.Console.WriteLine("\nFood ID : "+food.FoodID);
            System.Console.WriteLine("Food Name : "+food.FoodName);
            System.Console.WriteLine("Food Price : "+food.FoodPrice);
            System.Console.WriteLine("Quantity : "+food.AvailableQuantity+"\n");
        }

        // create temp card item list
        string choice;
        List<CardItem> cardItemsList = new List<CardItem>();

        // create temp order list
        OrderDetails order=new OrderDetails(currentUser.UserID,DateTime.Now,0,OrderStatus.Initiated);

        currentOrder=order;
        do
        {
            // ask food id and quantity
            System.Console.WriteLine("Enter Food ID and quantity : ");
            string tFoodID = Console.ReadLine().ToUpper();
            int tQuantity= int.Parse(Console.ReadLine());

            foreach(FoodDetails food in foodList)
            {
                if(tFoodID==food.FoodID)
                {
                    double tPrice=tQuantity*food.FoodPrice;
                    // check food is available
                    if(food.AvailableQuantity>=tQuantity)
                    {
                        food.AvailableQuantity-=tQuantity;
                        CardItem card = new CardItem(order.OrderID,tFoodID,tPrice,tQuantity);
                        cardItemsList.Add(card);
                        break;
                    }
                }
            }
            // check he want more food
            System.Console.WriteLine(" if you want another food, Enter yes else enter no : ");
            choice = Console.ReadLine().ToLower();
            while(choice!="yes" || choice!="no")
            {
                System.Console.WriteLine("Enter valid choice.");
                choice = Console.ReadLine().ToLower();
            }
            // else if you want to pay the ordered product
            if(choice=="no")
            {
                System.Console.WriteLine("You confirm to purchase. enter yes, else no : ");
                string string1 = Console.ReadLine().ToLower();
                if(string1=="no")
                {
                    // he didn't pay return all food quantity
                    foreach(CardItem card in cardItemsList)
                    {
                        if(currentOrder.OrderID==card.OrderID)
                        {
                            foreach(FoodDetails food in foodList)
                            {
                                // return food quantity
                                if(food.FoodID==card.FoodID)
                                {
                                    food.AvailableQuantity+=card.OrderQuantity;
                                }
                            }
                        }
                    }
                }
                else if(string1=="yes")
                {
                    double total=0;
                    foreach(CardItem card in cardItemsList)
                    {
                        if(card.OrderID==currentOrder.OrderID)
                        {
                            total=total+card.OrderPrice;
                        }
                    }
                    if(total<=currentUser.Balance)
                    {
                        // deduct amount from user balance
                        currentUser.DeductAmount(total);
                        foreach(CardItem card in cardItemsList)
                        {
                            cardsList.Add(card);
                        }
                        currentOrder.TotalPrice=total;
                        currentOrder.OrderStatus=OrderStatus.Ordered;
                        ordersList.Add(order);
                        System.Console.WriteLine("Order placed successfully, and OrderID is "+order.OrderID);
                    }
                    // else print
                    else
                    {
                        System.Console.WriteLine("In sufficient balance to purchase. Are you willing to recharge, \nEnter yes else no :");
                        string tempstring = Console.ReadLine().ToLower();
                        if(tempstring=="yes")
                        {
                            
                            System.Console.WriteLine("plese recharge : "+(total-currentUser.WalletBalance));
                            System.Console.WriteLine("Enter amount : ");
                            double amount = double.Parse(Console.ReadLine());
                            currentUser.WalletRecharge(amount);
                        }
                        else if(tempstring=="no")
                        {
                            System.Console.WriteLine("Exiting without Order due to insufficient balance.");
                            currentOrder.OrderStatus=OrderStatus.Cancelled;
                            foreach(CardItem card in cardItemsList)
                            {
                                foreach(FoodDetails food in foodList)
                                {
                                    if(card.FoodID==food.FoodID && card.OrderID==currentOrder.OrderID)
                                    {
                                        food.AvailableQuantity+=card.OrderQuantity;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }while(choice=="yes");
    }

    public static void ModifyOrder()
    {
        foreach(OrderDetails order in ordersList)
        {
            if(order.OrderStatus==OrderStatus.Ordered)
            {
                System.Console.WriteLine("\nOrder ID : "+order.OrderID);
                System.Console.WriteLine("Order date : "+order.OrderDate);
                System.Console.WriteLine("Price : "+order.TotalPrice);
            }
        }
        System.Console.WriteLine("Enter order ID : ");
        string tempOrderID = Console.ReadLine().ToUpper();
        
        foreach(OrderDetails order1 in ordersList)
        {
            if(order1.OrderID==tempOrderID && order1.OrderStatus==OrderStatus.Ordered)
            {
                foreach(CardItem card in cardsList)
                {
                    System.Console.WriteLine("\nItem ID : "+card.ItemID);
                    System.Console.WriteLine("Food ID : "+card.FoodID);
                    System.Console.WriteLine("Price : "+card.OrderPrice);
                    System.Console.WriteLine("Quantity : "+card.OrderQuantity+"\n");
                }
                System.Console.WriteLine("Enter Item ID : ");
                string tempItemID= Console.ReadLine();
                
                foreach(CardItem card1 in cardsList)
                {
                    if(card1.ItemID==tempItemID)
                    {
                        System.Console.WriteLine("Enter new quantity : ");
                        int tempQuantity = int.Parse(Console.ReadLine());

                        foreach(FoodDetails food in foodList)
                        {
                            if(card1.FoodID==food.FoodID)
                            {
                                double price = food.FoodPrice*tempQuantity;
                                order1.TotalPrice+=price;
                                currentUser.DeductAmount(price);
                                System.Console.WriteLine("Order modified successfully.");
                                break;
                            }
                        }

                    }
                }
            }
        }
    }
    public static void CancelOrder()
    {
        OrderHistory();

        System.Console.WriteLine("Enter order ID : ");
        string tempOrderID = Console.ReadLine();
        foreach(OrderDetails order in ordersList)
        {
            if(order.OrderID==tempOrderID && order.OrderStatus==OrderStatus.Ordered)
            {
                currentUser.WalletRecharge(order.TotalPrice);
                foreach(CardItem card in cardsList)
                {
                    if(order.OrderID==card.OrderID)
                    {
                        foreach(FoodDetails food in foodList)
                        {
                            food.AvailableQuantity+=card.OrderQuantity;
                        }
                        order.OrderStatus=OrderStatus.Cancelled;
                        System.Console.WriteLine("Order cancelled successfully.");
                    }
                }
            }
        }
    }

    public static void OrderHistory()
    {
        foreach(OrderDetails order in ordersList)
        {
            if(currentUser.UserID==order.UserID)
            {
                System.Console.WriteLine("\nOrder ID : "+order.OrderID);
                System.Console.WriteLine("Ordered Date : "+order.OrderDate);
                System.Console.WriteLine("Total Price : "+order.TotalPrice);
                System.Console.WriteLine("Order Status : "+order.OrderStatus);
            }
        }
    }

    public static void WalletRecharge()
    {
        System.Console.WriteLine("Enter amout to recharge : ");
        double amount =double.Parse(Console.ReadLine());
        
        currentUser.WalletRecharge(amount);
        ShowWalletBalance();
    }

    public static void ShowWalletBalance()
    {
        System.Console.WriteLine("Your Balance is "+currentUser.Balance);
    }

    public static void LoadDefaultData()
    {
        UserDetails user1 = new UserDetails("Ravichandran", "Ettapparajan", Gender.Male, 8857777575, "ravi@gmail.com", "WS101", 400);
        UserDetails user2 = new UserDetails("Baskaran", "Sethurajan", Gender.Male, 9577747744, "baskaran@gmail.com", "WS105", 500);

        usersList.Add(user1);
        usersList.Add(user2);

        FoodDetails food1 = new FoodDetails("Coffee", 20, 100);
        FoodDetails food2 = new FoodDetails("Tea", 15, 100);
        FoodDetails food3 = new FoodDetails("Biscuit", 10, 100);
        FoodDetails food4 = new FoodDetails("Juice", 50, 100);
        FoodDetails food5 = new FoodDetails("Puff", 40, 100);
        FoodDetails food6 = new FoodDetails("Milk", 10, 100);
        FoodDetails food7 = new FoodDetails("Popcorn", 20, 20);

        foodList.Add(food1);
        foodList.Add(food2);
        foodList.Add(food3);
        foodList.Add(food4);
        foodList.Add(food5);
        foodList.Add(food6);
        foodList.Add(food7);

        CardItem card1 = new CardItem("OID1001", "FID101", 20, 1);
        CardItem card2 = new CardItem("OID1001", "FID103", 10, 1);
        CardItem card3 = new CardItem("OID1001", "FID105", 40, 1);
        CardItem card4 = new CardItem("OID1002", "FID103", 10, 1);
        CardItem card5 = new CardItem("OID1002", "FID104", 50, 1);
        CardItem card6 = new CardItem("OID1002", "FID105", 40, 1);

        cardsList.Add(card1);
        cardsList.Add(card2);
        cardsList.Add(card3);
        cardsList.Add(card4);
        cardsList.Add(card5);
        cardsList.Add(card6);

        OrderDetails order1 = new OrderDetails("SF1001", new DateTime(2022,06,15), 70, OrderStatus.Ordered);
        OrderDetails order2 = new OrderDetails("SF1002", new DateTime(2022,06,15), 100, OrderStatus.Ordered);

        ordersList.Add(order1);
        ordersList.Add(order2);
    }
}