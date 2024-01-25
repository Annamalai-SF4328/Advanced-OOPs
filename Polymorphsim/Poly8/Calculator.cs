using System;
using System.Xml.Schema;

namespace OperatorOverloading
{
    public class Calculator
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }
        public  double Total = 0;
        public  double Percentage = 0;

        public Calculator(int mark1, int mark2, int mark3, int mark4, int mark5, int mark6)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Mark5 = mark5;
            Mark6 = mark6;
        }
        public Calculator()
        {

        }
        public void CalculationsTotal()
        {
            Total = Mark1 + Mark2 + Mark3 + Mark4 + Mark5 + Mark6;
            Percentage = Total / 6;


        }
        public static Calculator operator +(Calculator sem1, Calculator sem2)
        {
            Calculator temp = new Calculator();
            temp.Total = sem1.Total+sem2.Total;
            return temp;

        }

    }
}
