using System;

namespace SumOf_N_Numbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter How many numbers: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                sum += num;
            }
            
            Console.WriteLine("The sum of {1} numbers is:{0}", sum,n);
        }
    }
}
