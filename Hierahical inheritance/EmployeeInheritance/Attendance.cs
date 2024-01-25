using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    public class Attendance
    {
        private static int s_dayID=1000;
        public string DayID { get; }
        public DateTime Date { get; set; }
        public double NumberOfHoursWorked { get; set; }

        public Attendance(DateTime date, double numberOfHoursWorked)
        {
            s_dayID++;
            DayID="DID"+s_dayID;
            Date=date;
            NumberOfHoursWorked=numberOfHoursWorked;
        }
    }
}