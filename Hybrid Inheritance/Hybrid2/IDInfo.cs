using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public class IDInfo : PersonalInfo
    {
        public string VoterID { get; set; }
        public string AadharID { get; set; }
        public string PANNumber { get; set; }
    }
}