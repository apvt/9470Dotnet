using System;

namespace EvenOdd
{
     class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number\t");
            num=Convert.ToInt32(Console.ReadLine());
            if (num % 2==0){
                Console.WriteLine("{0}\tIs Even Number",num);
            }
            else
            {
                Console.WriteLine("{0}\tIs Odd Number",num);
            }  
            Console.ReadLine();
        }
    }
}
