using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTOSTRINGARRAY
{
    class LINQTOSTRINGARRAY
    {
        static void Main(string[] args)
        {
            //create an array of type string 
            string[] array = { "Vaishali", "Shalu", "Akshay", "Akki" };
            /*IEnumerable will iterate over the collection of data use 
            Linq query to select the particular element which starts from s*/
            IEnumerable<string> result = from a in array
                                         where a.ToLowerInvariant().StartsWith("s")
                                         select a;
            //foreach loop is used to print the output which is in the result 
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }    
    }
}
