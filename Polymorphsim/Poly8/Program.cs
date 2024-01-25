using System;
namespace OperatorOverloading
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator Sem1 = new Calculator(80, 90, 90, 90, 80, 80);
            Calculator Sem2 = new Calculator(80, 90, 90, 90, 80, 80);
            Calculator Sem3 = new Calculator(80, 90, 90, 90, 80, 80);
            Calculator Sem4 = new Calculator(80, 90, 90, 90, 80, 80);

            Sem1.CalculationsTotal();
            Sem2.CalculationsTotal();
            Sem3.CalculationsTotal();
            Sem4.CalculationsTotal();
                
            Calculator TotalMarks=new Calculator();
            TotalMarks=Sem1+Sem2+Sem3+Sem4;
            double Percentage=TotalMarks.Total/24;
            Console.WriteLine($"Total Mark is {TotalMarks.Total}");
            Console.WriteLine($"overall percentage{Percentage}");



        }
        
    }
}