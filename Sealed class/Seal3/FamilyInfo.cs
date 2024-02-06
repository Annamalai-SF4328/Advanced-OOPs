namespace Seal3
{
    public class FamilyInfo : PersonalInfo
    {
        public string MotherName { get; set; }
        public int NumberofSibilings { get; set; }
        public string NativPlace { get; set; }
        public FamilyInfo(string name, string fatherName, long mobile, string mail, Gender gender, string motherName, int numberofSibilings, string native) : base(name, fatherName, mobile, mail, gender)
        {
            MotherName = motherName;
            NumberofSibilings = numberofSibilings;
            NativPlace = native;
        }
        public sealed override void Update(string name, string fatherName, long mobile, string mail, Gender gender, string motherName, string native, int numberofSibilings)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
            MotherName = motherName;
            NumberofSibilings = numberofSibilings;
            NativPlace = native;

        }

    }
}
