using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class BookInfo : RackInfo
    {
        // property
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public double Price { get; set; }
        // constructor
        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookID,string bookName,string authorName,double price) : base(departmentName,degree,rackNumber,columnNumber)
        {
            BookID=bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
    }
}