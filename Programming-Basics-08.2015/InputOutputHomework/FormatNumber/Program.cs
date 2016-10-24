using System;

namespace FormatNumber
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            if (a < 0 || a > 500)
            {
                Console.WriteLine("Invalid number!");
                return;
            }
            Console.WriteLine(" (float) b= ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("(float)c= ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("|{0,-10}", Convert.ToString(a, 16).ToUpper());
            Console.Write("|{0,10}|", Convert.ToString(a, 2).PadLeft(10, '0'));
            string str = b.ToString();
            int index = str.IndexOf(".");
            Console.Write("{0,10:F2}|", b);
            str = c.ToString();
            index = str.IndexOf(".");
            Console.Write("{0,-10:F3}|", c);

        }
    }
}