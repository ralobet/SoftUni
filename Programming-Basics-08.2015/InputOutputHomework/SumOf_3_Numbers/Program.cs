using System;
namespace SumOf_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());
            double sum = number1 + number2 + number3;
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
