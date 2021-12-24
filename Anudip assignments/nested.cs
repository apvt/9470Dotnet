using System;
struct student
{
 public String name,last;
}
struct Marks //Nested Structure
{
 public student s;
 public int math, sci;
}
class nest
{
 public static void Main()
 {
 Marks m;
 m.s.name = "Apoorva";
 m.s.last = "Bari";
 m.math = 85;
 m.sci = 80;
 Console.WriteLine("Name = "+m.s.name);
 Console.WriteLine("Last Name = "+m.s.last);
 Console.WriteLine("Math Marks = "+m.math);
 Console.WriteLine("Science = "+m.sci);
 }
}