using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstract2
{
    public abstract class Library
    {
        private static int s_serialNumber=1000;
        public string SerialNumber { get{s_serialNumber++; return "LIB"+s_serialNumber;} }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract string Year { get; set; }
        

        public abstract void SetBookInfo(int count);
    }
}