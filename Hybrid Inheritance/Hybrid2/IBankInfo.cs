using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid2
{
    public interface IBankInfo
    {
        public string BankName { get; set; }
        public string IFSC { get; set; }
        public string BranchName { get; set; }
    }
}