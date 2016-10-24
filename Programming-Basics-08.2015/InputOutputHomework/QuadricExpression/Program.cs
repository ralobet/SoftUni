using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadricExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ax2+bx+c=0
             d=b^2-4*a*c
             if d = 0  x1 =x2 = -b/2a
             if d<0 no real roots
             if d>0 x1 = -b+sqrt(d)/2a
             x2= -b-sqrt(d)/2a*/
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = Math.Sqrt((b * b) - 4 * a * c);
            if (d < 0 )
            {
                Console.WriteLine("No real roots");
            }
            else if (d == 0)
            {
                double x1 = -b / (2 * a);
                double x2 = x1;
                Console.WriteLine("The roots are equal {0}", x1);
            }
            else 
            {
                double x1 = (-b -(d)) / (2 * a);
                double x2 = (-b + (d)) / (2 * a);
                Console.WriteLine("The roots are x1={0} and x2 ={1}", x1, x2);

            }
        }
    }
}
