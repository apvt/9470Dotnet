using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 namespace ex20
 {
   public class ex20
   {
     public static void Main(string[] args)
     {
       Console.WriteLine(result(13, 40));
            Console.WriteLine(result(50, 21));
            Console.WriteLine(result(0, 23));
        }

        public static int result(int a, int b)
        {      
            if (a > b)
            {
                return (a - b)*2;
            }
            return b - a;
     }
   }
 }
