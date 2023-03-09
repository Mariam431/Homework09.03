using _2_Inheritance;

namespace Homework09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctorParam = new Doctor(8);
            doctorParam.Testmethod();
            Console.WriteLine(doctorParam.Age + " doctorParam");

            HumanBase humanbaseParam = new HumanBase();
            Console.WriteLine(humanbaseParam.Age + " HumanBase");


        }
    }
}