using System;

namespace Seal1
{
    public sealed class EmployeeInfo
    {
        private static int s_userId = 1000;
        public static int KeyInfo = 100;

        //Properties
        public string EmployeeID { get; set; }
        public string Password { get; set; }

        public EmployeeInfo(string password)
        {
            EmployeeID = $"SF{++s_userId}";
            Password = password;
        }
        public void UpdateKey(int key){
           KeyInfo=key;
        }
        public void UpdatePassword(string password){
           Password=password;
        }


    }
}
