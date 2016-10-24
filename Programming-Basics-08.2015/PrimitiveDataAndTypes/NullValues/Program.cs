using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValues
{
    class Program
    {
        static void Main()
        {
            int? a = null;
            double? b = null;

            Console.WriteLine("First variable _{0}_ and second variable _{1}_", a, b);
            Console.WriteLine(b += 6);
            Console.WriteLine(a += 12);
            Console.WriteLine("a = _{0}_", a + 10);
            Console.WriteLine("b = _{0}_", b +2);
           
        }
    }
}
