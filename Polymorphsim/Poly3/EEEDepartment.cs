using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly3
{
    public class EEEDepartment : Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override string Year { get; set; }
        public int BookCount { get; set; }

        public EEEDepartment(string authorName,string bookName,string publisherName,string year)
        {
            AuthorName=authorName;
            BookName=bookName;
            PublisherName=publisherName;
            Year=year;
        }

        public override void SetBookInfo(int count)
        {
            BookCount=count;
        }
    }
}