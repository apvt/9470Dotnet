using System;

namespace ArraySort
{
     class Program
    {
        static void printarray(int[] arr)
        {
            Console.WriteLine("\n Elements of Array\n");
            foreach(int i in arr)
            {
                Console.Write("\t{0}", i);
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            for(i = 0; i < 5; i++)
            {
                Console.Write("Enter number\t");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program.printarray(arr);
            Array.Sort(arr);
            Program.printarray(arr);
            Console.ReadLine();
        }

    }
}
