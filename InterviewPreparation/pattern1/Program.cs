using System;

namespace pattern1
{
     class Program
    {
        public static void Main(string[] args)
        {
            int i, j, k;
            Console.Write("Input number of rows : ");
            k = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= k; i++)
            {
                /* print blank spaces */
                for (j = 1; j <= k - i; j++)
                    Console.Write(" ");
                /* Display number in asc order till middle*/
                for (j = 1; j <= i; j++)
                    Console.Write("{0}", j);

                /* Display  number in reverse order after middle */
                for (j = i - 1; j >= 1; j--)
                    Console.Write("{0}", j);

                Console.Write("\n");
            }
        }

    }
}
