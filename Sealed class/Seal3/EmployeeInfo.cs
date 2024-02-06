namespace Seal3
{
    public class EmployeeInfo : FamilyInfo
    {
        private static int s_employeeId = 1000;
        public string EmployeeId { get; set; }
        public DateTime DateOfJoining { get; set; }
        public EmployeeInfo(string name, string fatherName, long mobile, string mail, Gender gender, string motherName, int numberofSibilings, string native, DateTime date) : base(name, fatherName, mobile, mail, gender, motherName, numberofSibilings, native)
        {
            EmployeeId = $"EID{++s_employeeId}";
            DateOfJoining = date;
        }
        public override void Update()
        {
            
        }
    }
}
