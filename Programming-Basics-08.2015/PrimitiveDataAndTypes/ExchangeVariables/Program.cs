using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariables
{
    class Program
    {
        static void Main()
        {
            int value1 = 5;
            int value2 = 10;
            Console.WriteLine("before exchange value1 = {0} value2 = {1}", value1, value2);
            int value3 = value1;
            value1 = value2;
            value2 = value3;
            Console.WriteLine("after exchange value1 = {0} value2 = {1}", value1, value2);
        }
    }
}
