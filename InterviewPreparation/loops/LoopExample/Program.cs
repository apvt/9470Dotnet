using System;

namespace LoopExample
{
     class Program
    {
        static void Main(string[] args)
        {
            int i=0, j=0;
            for(i=0;i<=5;i++)
            {
                for(j=0;j<i;j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
