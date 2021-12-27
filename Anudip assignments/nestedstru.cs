using System;
struct student
{
 public String Firstname,Lastname,Address;
}
struct Marks
{
 public student s;
 public int math,sci,eng,physics,hindi;
}
class nest
{
 public static void Main()
 {
 Marks m;
 m.s.Firstname = "Apoorva";
 m.s.Lastname = "Bari";
 m.s.Address="xyz....";
 m.math = 75;
 m.sci = 70;
 m.eng = 70;
 m.physics = 80;
 m.hindi = 80;
 Console.WriteLine("First Name = "+m.s.Firstname);
 Console.WriteLine("Last Name = "+m.s.Lastname);
 Console.WriteLine("Address="+m.s.Address);
 Console.WriteLine("Math Marks = "+m.math);
 Console.WriteLine("Science = "+m.sci);
 Console.WriteLine("English = "+m.eng);
 Console.WriteLine("Physics = "+m.physics);
 Console.WriteLine("Hindi= "+m.hindi);
 }
}