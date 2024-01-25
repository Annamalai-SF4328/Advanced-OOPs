using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public enum Gender{Select, Male, Female}
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Qualification { get; set; }
    }
}