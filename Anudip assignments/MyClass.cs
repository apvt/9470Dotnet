using System;
class MyClass
{
string myField = string.Empty;
 MyClass(){}
static void MyMethod(int parameter1, string parameter2)
{
Console.WriteLine("First Parameter {0}, Second parameter {1}",parameter1, parameter2);
 }
 private int myPropertyVar;
 public int MyProperty
 {
  get { return myPropertyVar; }
  set { myPropertyVar = value; }
 }
 public static void Main()
 {
   MyClass my = new MyClass();
    my.myPropertyVar = 10;
    Console.WriteLine(my.myPropertyVar);
 }
 }
 
 
