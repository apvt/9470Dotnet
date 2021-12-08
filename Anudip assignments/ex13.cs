using System;
 namespace ex13
 {
   public class ex13
   {
     public static void Main(string[] args)
     {
        int x;      
        Console.Write("Enter a number: ");
        x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}{0}{0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0} {0}",x);
        Console.WriteLine("{0}{0}{0}",x);
     }
   }
 }
