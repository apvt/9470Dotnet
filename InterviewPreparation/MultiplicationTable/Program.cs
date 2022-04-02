using System;

namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j, i;

            Console.Write("\n\n");
            Console.Write("Multiplication table of:");
            i = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", i, j, i * j);
            }
        }
    }
}
