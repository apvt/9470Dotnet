using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
 // Compiler version 4.0, .NET Framework 4.5


 namespace Program
 {
   public class Program
   {
     public static void Main(string[] args)
     {
       //Your code goes here
       Console.WriteLine("Hello");
       string email="apoorvabari16@gmail.com";
       var result = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
     Console.Write("is valid:{0}",result);
     Console.ReadLine();
     }
   }
 }
