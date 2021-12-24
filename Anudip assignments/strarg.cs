using System;
struct str
{
 int a,b;
 public str(int x, int y)
 {
 a = x;
 b = y;
 }
 public void show()
 {
 int c = a + b;
 Console.WriteLine("Sum="+c);
 }
}
class student
{
 public static void Main()
 {
 str obj = new str();
 obj.show();
 }
}