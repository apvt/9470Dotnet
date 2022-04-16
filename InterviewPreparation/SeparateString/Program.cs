using System;

namespace SeparateString
{
    class Program
    {
        public static void Main()
        {
            string str;
            int a = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (a <= str.Length - 1)
            {
                Console.Write("{0} ", str[a]);
                a++;
            }
            Console.Write("\n\n");
        }
    }
}

    
