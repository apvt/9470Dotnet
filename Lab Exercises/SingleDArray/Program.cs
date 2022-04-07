//Write a program of sorting an array.
//    Declare single dimensional array and accept 5 integer values from the user. 
//    Then sort the input in ascending order and display output.


using System;

namespace SingleDArray
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int n, i, j, tmp;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }
            Console.Write("\nElements in ascending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");
        }
    }
}
