using System;

namespace NumbersDevisibleByNumber
{
    class Program
    {
        static void Main()
        {
            /*Write a program that reads two positive integer numbers 
             * and prints how many numbers p exist between them 
             * such that the reminder of the division by 5 is 0. Examples:*/
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            if (number1 > number)
            {
                for (int i = number; i <= number1; i++)
                {
                    int devisible = i;
                    if (devisible % 5 == 0)
                    {

                        Console.Write("{0}, ", devisible);
                    }
                }
            }
            else
            {
                for (int i = number1; i <= number; i++)
                {
                    int devisible = i;
                    if (devisible % 5 == 0)
                    {
                        Console.Write("{0}, ", devisible);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}