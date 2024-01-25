using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poly4
{
    public class FreeLancer : PersonalDetails
    {
        public string Role { get; set; }
        private int _salaryAmount;
        public double SalaryAmount { get{return _salaryAmount;} }
        public int NoOfWorkingDays { get; set; }
        
        public virtual void CalculateSalary()
        {
            _salaryAmount= NoOfWorkingDays*500;
        }
    }
}