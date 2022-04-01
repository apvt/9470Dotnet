using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string city;
            int age;
            int pinno;
            //accepting value from user
            Console.WriteLine("Enter your name :\n");
            name=Console.ReadLine();
            Console.WriteLine("Enter your city :\n");
            city = Console.ReadLine();
            Console.WriteLine("Enter your age :\n");
            age=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter your pinno :\n");
            pinno = Int32.Parse(Console.ReadLine());
            //printing values
            Console.WriteLine("==================================================");
            Console.WriteLine("Your complete address :");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("Name={0}",name);
            Console.WriteLine("City={0}", city);
            Console.WriteLine("Age={0}", age);
            Console.WriteLine("Pinno={0}", pinno);
            Console.ReadLine();
        }
    }
}
