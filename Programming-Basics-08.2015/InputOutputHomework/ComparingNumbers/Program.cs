using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1>number2)
            {
                Console.WriteLine("{0} is greather than {1} ",number1,number2);
            }
            else
            {
                Console.WriteLine("{0} is greather than {1} ", number2, number1);
            }
        }
    }
}
