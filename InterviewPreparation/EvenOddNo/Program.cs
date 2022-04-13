using System;

namespace EvenOddNo
{
     class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}",a);
            if(a%2==0)
            {
                Console.WriteLine("It is even number",a);
            }
            else
            {
                Console.WriteLine("It is odd number", a);
            }
            Console.ReadLine();
        }
    }
}
