using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 namespace ex19
 {
   public class ex19
   {
     public static void Main(string[] args)
     {
       Console.WriteLine(SumTriple(2,2));
            Console.WriteLine(SumTriple(12,10));
            Console.WriteLine(SumTriple(-5,2));          
        }
        public static int SumTriple(int a, int b)
        {
            return a == b ? (a + b)*3 : a + b;
     }
   }
 }
