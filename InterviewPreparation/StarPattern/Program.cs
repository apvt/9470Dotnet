using System;

namespace StarPattern
{
     class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            Console.Write("Input number of rows : ");
            rows = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
