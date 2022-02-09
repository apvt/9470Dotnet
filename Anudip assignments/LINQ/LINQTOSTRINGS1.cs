using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LINQTOSTRINGS
{
    class LINQTOSTRINGS1
    {
        static void Main(string[] args)
        {
            //create a string 'str1' 
            string str1 = "Welcome to Java T Point.Com";
            //here StringSplitOptions.RemoveEmptyEntries() is used to remove the spaces between the words. 
            var result = from s in str1.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select s;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
    

