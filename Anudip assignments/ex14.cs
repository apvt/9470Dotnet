using System;
 namespace ex14
 {
   public class ex14
   {
     public static void Main(string[] args)
     {
       Console.Write("Enter the amount of Celsius: "); 
        int celsius = Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("Kelvin = {0}", celsius + 273);
        Console.WriteLine("Fahrenheit = {0}", celsius * 18 / 10 + 32);
     }
   }
 }
