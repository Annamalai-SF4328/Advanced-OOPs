using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineLibrary
{
    public class BookInfo : DepartmentDetails
    {
        // Auto increment ID
        private static int s_bookID=2000;
        // property
        public string BookID { get; }
        public string BookName { get; set; }
        public string AuthourName { get; set; }
        public double Price { get; set; }

        // Constructor
        public BookInfo(string departmentName, string degree,string departmentID,string bookName,string authourName, double price) : base(departmentName, degree, departmentID)
        {
            s_bookID++;
            BookID="BID"+s_bookID;
            BookName=bookName;
            AuthourName=authourName;
            Price=price;
        }
    }
}