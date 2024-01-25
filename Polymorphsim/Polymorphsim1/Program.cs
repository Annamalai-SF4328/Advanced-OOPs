using System;
namespace Polymorphsim1;
class Program
{
    public static void Main(string[] args)
    {
        Multiply multiplyObject = new Multiply();
        
        System.Console.WriteLine("one integer : "+multiplyObject.Method(2));
        System.Console.WriteLine("two integer : "+multiplyObject.Method(4,5));
        System.Console.WriteLine("3 integer : "+multiplyObject.Method(2,5,8));
        System.Console.WriteLine("1 int and long : "+multiplyObject.Method(2,100000100101));
        System.Console.WriteLine("int long double : "+ multiplyObject.Method(2,10000100101,3.44));
    }
}