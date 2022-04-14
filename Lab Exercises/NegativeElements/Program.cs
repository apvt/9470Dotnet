using System;

namespace NegativeElements
{
     class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            int i,n;
            Console.Write("Input  elements in the array :\n");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine("Negative elements in array are : {0}",arr[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
