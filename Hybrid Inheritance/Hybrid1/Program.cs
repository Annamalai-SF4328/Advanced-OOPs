using System;
using Hybrid1;
namespace Hyybrid1;
class Program
{
    public static void Main(string[] args)
    {
        double[] s1={9.8,7,8.3,8,9,8.6};
        double[] s2={6,9,6.3,7,7.6,6.9};
        double[] s3={7,8,9.5,8.5,8,6};
        double[] s4={9.5,7,8,9.1,6,7};
        
        MarkSheet markSheet = new MarkSheet("75432","ABCD","abcd",9876543210,new DateTime(2002,11,11),Gender.Male,s1,s2,s3,s4,DateTime.Now);

        System.Console.WriteLine(markSheet.ShowUGMarkSheet());
    }
}