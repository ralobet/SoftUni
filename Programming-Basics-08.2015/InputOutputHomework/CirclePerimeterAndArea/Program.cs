using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {

            double r, pi = 3.14, area, perimeter;
            Console.Write("Please enter radius of circle : ");
            r = Convert.ToInt32(Console.ReadLine());
            area = pi * r * r;
            perimeter = 2 * pi * r;
            Console.WriteLine(area + " sq units" + " is area of circle with given radius");
            Console.WriteLine(perimeter + " units" + " is perimeter of circle with given radius");
        }
    }
}
