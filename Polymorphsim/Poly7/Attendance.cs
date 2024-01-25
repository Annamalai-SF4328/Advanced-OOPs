using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly7
{
    public class Attendance
    {
        public int TotalWorkingDays { get; set; }
        public int LeaveTaken { get; set; }
        public int PermissionTaken { get; set; }
        
        public Attendance(int totalWorkingDays,int leaveTaken, int permissionTaken)
        {
            TotalWorkingDays=totalWorkingDays;
            LeaveTaken=leaveTaken;
            PermissionTaken=permissionTaken;
        }
        
        public static Attendance operator +(Attendance month1, Attendance month2)
        {
            int totalWorkingDays=month1.TotalWorkingDays+month2.TotalWorkingDays;
            int leaveTaken=month1.LeaveTaken+month2.LeaveTaken;
            int permissionTaken=month1.PermissionTaken+month2.PermissionTaken;
            return new Attendance(totalWorkingDays,leaveTaken,permissionTaken);
        }

        public double CalculateSalary()
        {
            int workingDays=TotalWorkingDays-LeaveTaken;
            return workingDays*500;
        }
    }
}