using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStoresNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 3;
            Person[] persons = new Person[total];
            Console.WriteLine("Enter three names:");
            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            Console.ReadLine();
        }

        public class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }
        }
    }
}