using System;

namespace Check_UncheckException
{
     class Program
    {
        static void Main(string[] args)
        {
            sbyte num1 = 20, num2 = 31, result;
            try
            {
                unchecked {
                    result = (sbyte)(num1 * num2);
                    Console.WriteLine("{0}x{1}={2}", num1, num2, result);
                }
                checked
                {
                    result = (sbyte)(num1 * num2);
                    Console.WriteLine("{0}x{1}={2}", num1, num2, result);
                }
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.ReadKey();
            
        }
    }
}
