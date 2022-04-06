using System;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            //Declaring multi dimensional array
            string[,] language = new string[3, 3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("\nEnter languages for {0}. Row and {1}. column:\t", i + 1, j + 1);
                    language[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("\n\n=========================");
            Console.WriteLine("All the element of languages array is:\n\n");
            //Formatting Output
            Console.Write("\t1\t2\t3\n\n");
            //outer loop for accessing rows
            for (i = 0; i < 3; i++)
            {
                Console.Write("{0}.\t", i + 1);
                //inner or nested loop for accessing column of each row
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", language[i, j]);
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\n=========================");
            Console.ReadLine();
        }
    }
}
