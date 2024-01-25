using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public enum Gender{Select, Male, Female}
    public class PersonalInfo
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public long Mobile { get; set; }
    }
}