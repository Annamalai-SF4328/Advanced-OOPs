using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphsim1
{
    public class Multiply
    {
        public int Method(int number1)
        {
            return number1*number1;
        }
        public long Method(int number1,int number2)
        {
            return number1*number2;
        }
        public long Method(int number1,int number2,int number3)
        {
            return number1*number2*number3;
        }
        public long Method(int number1,long number4)
        {
            return number1*number4;
        }
        public double Method(int number1,long number2,double number4)
        {
            return number1*number2*number4;
        }

    }
}