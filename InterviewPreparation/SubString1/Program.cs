using System;

namespace SubString1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string a = Console.ReadLine();

            int len = a.Length;
            Console.WriteLine("All substrings for given string are : ");

            
            for (int i = 0; i < len; i++)
            {
                
                for (int j = 0; j < len - i; j++)
                {
                    Console.Write(a.Substring(i, j + 1) + " ");
                }
            }

            Console.ReadKey();
        }
    }
}