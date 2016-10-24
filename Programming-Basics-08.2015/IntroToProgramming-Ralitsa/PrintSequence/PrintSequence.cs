using System;
namespace PrintSequence
{
    class PrintSequence
    {
        static void Main()
        {

            int sequenceMember;
            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 == 0)
                {
                    sequenceMember = i;
                }
                else
                {
                    sequenceMember = i * (-1);
                }
                Console.Write(" {0}, ", sequenceMember);
            }
        }
    }
}
