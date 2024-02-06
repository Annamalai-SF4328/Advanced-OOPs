using System;
using System.Globalization;

namespace Seal1
{
    //enum
    public enum Gender { Male, Female }

    public class PesrsonalInfo
    {
        //properties
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }

        public void UpdateInf0()
        {

        }
    }
}
