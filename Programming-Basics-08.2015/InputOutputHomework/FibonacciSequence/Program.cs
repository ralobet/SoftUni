using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int x = 0;
            int y= 1;
            Console.Write("{0} {1}", x, y);
            for (int i = 2; i < number; i++)
            {
                int z = x + y;
                Console.Write(" {0} ", z);
                x = y;
                y = z;     
            }
            Console.WriteLine(" ");
        }
    }
}
