using System;

namespace Poly5
{
    public enum Gender { Male, Female }
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long MobileNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
