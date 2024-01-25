using System;
using System.Collections.Generic;
namespace OnlineGroceryStoreApplication;

class Program
{
    static List<CustomerRegistration> registrationsList = new List<CustomerRegistration>();
    static List<ProductDetails> productsList = new List<ProductDetails>();
    static List<BookingDetails> bookingsList = new List<BookingDetails>();
    static List<OrderDetails> ordersList = new List<OrderDetails>();
    static CustomerRegistration currentCustomer;

    public static void Main(string[] args)
    {
        LoadDefaultData();
        bool flag = true;
        do
        {
            System.Console.WriteLine("\nMain Menu\n1. Customer Registration,\n2. Customer Login,\n3. Exit\n");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    Registration();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    flag=false;
                    break;
                }
                default:
                {
                    System.Console.WriteLine("Enter valid option.");
                    break;
                }
            }
        } while (flag);
    }

    public static void Registration()
    {
        System.Console.WriteLine("\nEnter your name : ");
        string name = Console.ReadLine();
        System.Console.WriteLine("Enter Father name : ");
        string fatherName = Console.ReadLine();
        System.Console.WriteLine("Enter Genter : ");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(),true);
        System.Console.WriteLine("Enter mobile : ");
        long mobile=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter DOB as MM/dd/yyyy : ");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(),"MM/dd/yyyy",null);
        System.Console.WriteLine("Enter mail ID : ");
        string mailID = Console.ReadLine();
        System.Console.WriteLine("Your initial balance is 0.");
        
        CustomerRegistration customer1 = new CustomerRegistration(0, name, fatherName, gender, mobile, dob, mailID);
        System.Console.WriteLine("Your customer ID : "+customer1.CustomerID);

        registrationsList.Add(customer1);
    }

    public static void Login()
    {
        System.Console.WriteLine("Enter customer ID : ");
        string loginID = Console.ReadLine().ToUpper();
        bool flag=true;

        // check customer ID and show submenu
        foreach(CustomerRegistration customer in registrationsList)
        {
            if(loginID==customer.CustomerID)
            {
                flag=false;
                currentCustomer=customer;
                // call Submenu
                SubMenu();
            }
        }
        if(flag)
        {
            System.Console.WriteLine("Invalid Customer ID.");
        }
    }

    public static void SubMenu()
    {
        bool flag=true;
        do
        {
            System.Console.WriteLine("\nSub Menu\n1) Show Customer Details,\n2)	Show Product Details,\n3) Wallet Recharge,\n4) Take Order,\n5) Modify Order Quantity\n6) Cancel Order,\n7) Show Balance,\n8) Exit\n");
            
            System.Console.WriteLine("Enter option : ");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                case 1:
                {
                    ShowCustomerDetails();
                    break;
                }
                case 2:
                {
                    ShowProductDetails();
                    break;
                }
                case 3:
                {
                    WalletRecharge();
                    break;
                }
                case 4:
                {
                    TakeOrder();
                    break;
                }
                case 5:
                {
                    ModifyOrderQuantity();
                    break;
                }
                case 6:
                {
                    CancelOrder();
                    break;
                }
                case 7:
                {
                    ShowBalance();
                    break;
                }
                case 8:
                {
                    flag=false;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }while(flag);
    }

    public static void ShowCustomerDetails()
    {
        foreach(CustomerRegistration customer in registrationsList)
        {
            if(currentCustomer.CustomerID==customer.CustomerID)
            {
                System.Console.WriteLine("\nCustomer ID : "+customer.CustomerID);
                System.Console.WriteLine("Name : "+customer.Name);
                System.Console.WriteLine("Father Name : "+customer.FatherName);
                System.Console.WriteLine("Gender : "+customer.Gender);
                System.Console.WriteLine("Mobile : "+customer.Mobile);
                System.Console.WriteLine("DOB : "+customer.DOB);
                System.Console.WriteLine("Mail ID : "+customer.MailID);
                System.Console.WriteLine("Current Balance : "+customer.WalletBalance);
                break;
            }
        }
    }

    public static void ShowProductDetails()
    {
        foreach(ProductDetails product in productsList)
        {
            System.Console.WriteLine("\nProduct ID : "+product.ProductID);
            System.Console.WriteLine("Product Name : "+product.ProductName);
            System.Console.WriteLine("Quantity Available : "+product.QuantityAvailable);
            System.Console.WriteLine("Price Per Quantity : "+product.PricePerQuantity+"\n");
        }
    }

    public static void WalletRecharge()
    {
        System.Console.WriteLine("\nEnter amount to recharge : ");
        double amount = double.Parse(Console.ReadLine());

        currentCustomer.WalletRecharge(amount);

        ShowBalance();
    }

    public static void TakeOrder()
    {
        // ask customer to purchase
        System.Console.WriteLine("If you want to purchase, Enter yes else no : ");
        string choice1 =Console.ReadLine().ToLower();
        
        // yes -> Create booking details object 
        if(choice1=="yes")
        {
            // create Booking object
            BookingDetails booking = new BookingDetails(currentCustomer.CustomerID, 0, DateTime.Now, BookingStatus.Initiated);
            
            // create local tempOrderList
            List<OrderDetails> tempOrderList= new List<OrderDetails>();
            double price = 0;
            int quantity = 0;

            string option="yes";
            do
            {
                // show product details
                ShowProductDetails();

                // ask ProductID and validate it
                System.Console.WriteLine("\nEnter Product ID : ");
                string tempProductID = Console.ReadLine().ToUpper();
                bool flag1=true;
                
                foreach(ProductDetails product in productsList)
                {
                    if(product.ProductID==tempProductID)
                    {
                        flag1=false;
                        // ok -> ask Purchase quantity
                        System.Console.WriteLine("\nEnter purchase Quantity : ");
                        int tempPurchaseQuantity = int.Parse(Console.ReadLine());

                        // check Purchase quantity is available 
                        if(product.QuantityAvailable>=tempPurchaseQuantity)
                        {
                            // Calculate totalPurchaseAmount
                            double tempPrice = tempPurchaseQuantity*product.PricePerQuantity;
                            price=price+tempPrice;
                            quantity+=tempPurchaseQuantity;

                            // ok -> create order object and store in tempOrderList
                            OrderDetails order = new OrderDetails(booking.BookingID, product.ProductID, tempPurchaseQuantity, tempPrice);
                            tempOrderList.Add(order);

                            // reduce purchase count
                            product.QuantityAvailable-=tempPurchaseQuantity;

                            // show Product successfully added to cart
                            System.Console.WriteLine("Product successfully added to cart.");

                            // ask book another product, if yes again book
                            System.Console.WriteLine("\nIf you want book another product, enter yes, else no : ");
                            option = Console.ReadLine().ToLower();
                            // No -> exit loop
                            break;
                        }
                    }
                }
                // else show Invalid Product ID
                if(flag1)
                {
                    System.Console.WriteLine("\nInvalid Product ID.\n");
                }
            }while(option=="yes");
            bool flag = false;
            do
            {
                // ask confirm order, yes -> check balance and reduce balance
                System.Console.WriteLine("If you buy this order, Enter yes, else no : ");
                string option1 = Console.ReadLine();
                if(option1=="yes")
                {
                    if(price<=currentCustomer.WalletBalance)
                    {
                        currentCustomer.DeductBalance(price);
                        // Update the booking status to Booked, update total price, and add the object to list. 
                        booking.BookingStatus=BookingStatus.Booked;
                        booking.TotalPrice=price;
                        bookingsList.Add(booking);

                        // Add the tempOrderList to orderList. Show “Booking successful”.
                        foreach(OrderDetails order in tempOrderList)
                        {
                            ordersList.Add(order);
                        }
                        System.Console.WriteLine("Booking successful");
                        flag=false;
                        break;
                    }
                    // NO balance -> show Insufficient account balance recharge with”+totalPurchaseAmount 
                    else
                    {
                        System.Console.WriteLine("Insufficient account balance recharge with "+(price-currentCustomer.WalletBalance));
                        // proceed recharge
                        WalletRecharge();
                        flag=true;
                        // again ask to confirm order
                    }
                }
                else if(option1=="no")
                {
                    // No -> tempOrderList update product count to product detail list. And show cart removed successfully.
                    foreach(ProductDetails product in productsList)
                    {
                        foreach(OrderDetails order in tempOrderList)
                        {
                            if(order.ProductID==product.ProductID)
                            {
                                product.QuantityAvailable+=order.PurchaseCount;
                                break;
                            }
                        }
                    }
                    System.Console.WriteLine("cart removed successfully.");
                    flag=false;
                }
            }while(flag);
            
        }
    }

    public static void ModifyOrderQuantity()
    {
        foreach(BookingDetails booking in bookingsList)
        {
            if(currentCustomer.CustomerID==booking.CustomerID && BookingStatus.Booked==booking.BookingStatus)
            {
                // show order details
                foreach(OrderDetails order in ordersList)
                {
                    if(order.BookingID==booking.BookingID)
                    {
                        System.Console.WriteLine("\norder ID : "+order.OrderID);
                        System.Console.WriteLine("Product ID : "+order.ProductID);
                        System.Console.WriteLine("Booking ID : "+order.BookingID);
                        System.Console.WriteLine("Purchase Count  : "+order.PurchaseCount);
                        System.Console.WriteLine("Price Of Order : "+order.PriceOfOrder+"\n");
                    }
                }
                // ask order ID
                System.Console.WriteLine("\nEnter Order ID to modify : ");
                string tempOrderID = Console.ReadLine().ToUpper();
                
                foreach(OrderDetails order in ordersList)
                {
                    // Ensure order id is available
                    if(order.OrderID==tempOrderID)
                    {
                        System.Console.WriteLine("Enter the new quantity of product : ");
                        int tempQuantity = int.Parse(Console.ReadLine());
                        double total = 0;

                        // calculate price
                        foreach(ProductDetails product in productsList)
                        {
                            if(order.ProductID==product.ProductID)
                            {
                                // calculate price and add quantity
                                total=total+(tempQuantity*product.PricePerQuantity);

                                // update in order
                                order.PurchaseCount=tempQuantity;
                                order.PriceOfOrder=total;
                                foreach(BookingDetails booking1 in bookingsList)
                                {
                                    if(order.BookingID==booking1.BookingID)
                                    {
                                        booking1.TotalPrice=total;
                                        System.Console.WriteLine("order modified successfully");
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }
    }

    public static void CancelOrder()
    {
        // show booking details for current customer and booking status is booked
        foreach(BookingDetails booking in bookingsList)
        {
            if(currentCustomer.CustomerID==booking.CustomerID && booking.BookingStatus==BookingStatus.Booked)
            {
                System.Console.WriteLine("Booking ID : "+booking.BookingID);
                System.Console.WriteLine("Total Price : "+booking.TotalPrice);
                System.Console.WriteLine("Date Of Booking : "+booking.DateOfBooking);
                System.Console.WriteLine("Booking Status : "+booking.BookingStatus);
            }
        }

        // ask booking id to order cancel
        System.Console.WriteLine("Enter Booking ID : ");
        string tempBookingID = Console.ReadLine().ToUpper();
        bool flag=false;
        
        foreach(BookingDetails booking in bookingsList)
        {
            if(currentCustomer.CustomerID==booking.CustomerID && booking.BookingStatus==BookingStatus.Booked && tempBookingID==booking.BookingID)
            {
                // booking status change to cancell and refund the amount to customer balance
                booking.BookingStatus=BookingStatus.Cancelled;
                currentCustomer.WalletRecharge(booking.TotalPrice);

                // return products count to products
                foreach(OrderDetails order in ordersList)
                {
                    foreach(ProductDetails product in productsList)
                    {
                        if(product.ProductID==order.ProductID && order.BookingID==booking.BookingID)
                        {
                            flag=true;
                            product.QuantityAvailable+=order.PurchaseCount;
                            break;
                        }
                    }
                }
            }
        }
        // Show booking cancelled successfully
        if(flag)
        {
            System.Console.WriteLine("booking cancelled successfully");
        }
    }

    public static void ShowBalance()
    {
        System.Console.WriteLine("\nYour Balance is "+currentCustomer.WalletBalance);
    }

    public static void LoadDefaultData()
    {
        CustomerRegistration customer1 = new CustomerRegistration(10000, "Ravi", "Ettapparajan", Gender.Male, 974774646, new DateTime(1999, 11, 11), "ravi@gmail.com");
        CustomerRegistration customer2 = new CustomerRegistration(15000, "Baskaran", "Sethurajan", Gender.Male, 847575775, new DateTime(1999, 11, 11), "baskaran@gmail.com");

        registrationsList.Add(customer1);
        registrationsList.Add(customer2);

        ProductDetails product1 = new ProductDetails("Sugar", 20, 40);
        ProductDetails product2 = new ProductDetails("Rice", 100, 50);
        ProductDetails product3 = new ProductDetails("Milk", 10, 40);
        ProductDetails product4 = new ProductDetails("Cofee", 10, 10);
        ProductDetails product5 = new ProductDetails("Tea", 10, 10);
        ProductDetails product6 = new ProductDetails("Masala Powder", 10, 20);
        ProductDetails product7 = new ProductDetails("Salt", 10, 10);
        ProductDetails product8 = new ProductDetails("Turmeric Powder", 10, 25);
        ProductDetails product9 = new ProductDetails("Chilli Powder", 10, 20);
        ProductDetails product10 = new ProductDetails("Groundnut Oil", 10, 140);

        productsList.Add(product1);
        productsList.Add(product2);
        productsList.Add(product3);
        productsList.Add(product4);
        productsList.Add(product5);
        productsList.Add(product6);
        productsList.Add(product7);
        productsList.Add(product8);
        productsList.Add(product9);
        productsList.Add(product10);

        BookingDetails booking1 = new BookingDetails("CID1001", 220, new DateTime(2022, 07, 26), BookingStatus.Booked);
        BookingDetails booking2 = new BookingDetails("CID1002", 400, new DateTime(2022, 07, 26), BookingStatus.Booked);
        BookingDetails booking3 = new BookingDetails("CID1001", 280, new DateTime(2022, 07, 26), BookingStatus.Cancelled);
        BookingDetails booking4 = new BookingDetails("CID1002", 0, new DateTime(2022, 07, 26), BookingStatus.Initiated);

        bookingsList.Add(booking1);
        bookingsList.Add(booking2);
        bookingsList.Add(booking3);
        bookingsList.Add(booking4);

        OrderDetails order1 = new OrderDetails("BID3001", "PID2001", 2, 80);
        OrderDetails order2 = new OrderDetails("BID3001", "PID2002", 2, 100);
        OrderDetails order3 = new OrderDetails("BID3001", "PID2003", 1, 40);
        OrderDetails order4 = new OrderDetails("BID3002", "PID2001", 1, 40);
        OrderDetails order5 = new OrderDetails("BID3002", "PID2002", 4, 200);
        OrderDetails order6 = new OrderDetails("BID3002", "PID2010", 1, 140);
        OrderDetails order7 = new OrderDetails("BID3002", "PID2009", 1, 20);
        OrderDetails order8 = new OrderDetails("BID3003", "PID2002", 2, 100);
        OrderDetails order9 = new OrderDetails("BID3003", "PID2008", 4, 100);
        OrderDetails order10 = new OrderDetails("BID3003", "PID2001", 2, 80);

        ordersList.Add(order1);
        ordersList.Add(order2);
        ordersList.Add(order3);
        ordersList.Add(order4);
        ordersList.Add(order5);
        ordersList.Add(order6);
        ordersList.Add(order7);
        ordersList.Add(order8);
        ordersList.Add(order9);
        ordersList.Add(order10);
    }
}