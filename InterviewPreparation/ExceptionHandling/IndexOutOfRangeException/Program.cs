using System;

namespace Index_OutOfRange_Exception
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] a = new int[4];

            try
            {
                Console.WriteLine("Enter the elements:");
                for (int i = 0; i <= 4; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
