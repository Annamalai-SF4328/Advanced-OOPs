
namespace Seal3
{
    class Program{
        public static void Main(string[] args)
        {
            EmployeeInfo employee=new EmployeeInfo("abcd","efgh",353443,"abcd@g.com",Gender.Male,"abcd",2,"arni",new DateTime(2001,06,04));
            employee.Update();

        }
    }
}