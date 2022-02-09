using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetOperators
{
    class Distinct
    {
        static void Main(string[] args)
        {
            string[] countries = { "UK", "India", "Australia", "uk", "india", "USA" }; IEnumerable<string> result = countries.Distinct(StringComparer.OrdinalIgnoreCase); foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }

}