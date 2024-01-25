using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid1
{
    public enum Gender{Select, Male, Female}
    public class PersonalInfo
    {
        public string RegistorNumber { get; set;}
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }
    }
}