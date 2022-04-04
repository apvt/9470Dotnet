using System;

namespace User_Defined_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Welcome");
            a = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a == 5 || a < 5)
                {
                    Console.WriteLine("Congratulations you have got an{0}", a);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutOfStockException("OutOfStockException Generated"));
                }
            }
            catch (OutOfStockException oe)
            {
                Console.WriteLine(oe.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}

      //creating custom Exception
      public class OutOfStockException : Exception
      {
          public OutOfStockException(string message) : base(message)
          {
                        
          }
      }
