//program to display all Substrings present in the given String

using System;

namespace SubString
{
     class Program
    {
        static void Main(string[] args)
        {
            string str = "abc";
            for(int i = 1; i<str.Length; i++)
            {
                for(int j = 0; j<str.Length; j++)
                {
                    string substr = str.Substring(j, i);
                    Console.WriteLine(substr);
                }
            }
        }
    }
}
