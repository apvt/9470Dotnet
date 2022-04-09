using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str, reversestring = "";
            int a;
            Console.Write("Enter A String : ");
            Str = Console.ReadLine();
            a = Str.Length - 1;
            while (a >= 0)
            {
                reversestring = reversestring + Str[a];
                a--;
            }
            Console.WriteLine("Reverse  String  Is : {0}", reversestring);
            Console.ReadLine();
        }
    }
}