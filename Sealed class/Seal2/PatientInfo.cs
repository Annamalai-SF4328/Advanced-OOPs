using System;
using System.Dynamic;

namespace Seal2
{
    public sealed class PatientInfo
    {
        private static int s_patientId = 0;
        public string PatientId { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }

        public string AdmittedFor { get; set; }
        public PatientInfo(string name, string fatherName, int bedNo, string native, string admittedFor)
        {
            PatientId = $"PI{s_patientId}";
            Name = name;
            FatherName = fatherName;
            BedNo = bedNo;
            NativePlace = native;
            AdmittedFor = admittedFor;

        }
    }
}
