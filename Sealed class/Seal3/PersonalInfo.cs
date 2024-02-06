namespace Seal3
{
    public enum Gender { Male, Female }
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public long Mobile { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name, string fatherName, long mobile, string mail, Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
        public virtual void Update(string name, string fatherName, long mobile, string mail, Gender gender, string motherName, string native, int numberofSibilings)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;

        }


    }
}
