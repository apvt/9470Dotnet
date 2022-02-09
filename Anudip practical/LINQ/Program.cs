using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, -6, 3, 0, -4, 25 };
            // Query that selects only positive numbers.
            var result = from n in nums
                         where n > 0
                         select n;
            Console.Write("The positive values in nums: ");
            // Execute the query.
            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }    
}
