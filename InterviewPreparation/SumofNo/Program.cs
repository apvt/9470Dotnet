using System;

namespace SumofNo
{
     class Program
    {
        public static void Main()
        {
            int j, sum = 0;

            Console.Write("The first 10 natural number are :\n");
            for (j = 1; j <= 10; j++)
            {
                sum = sum + j;
                Console.Write("{0} ", j);
            }
            Console.Write("\nThe Sum is : {0}\n", sum);
        }
    }
}
