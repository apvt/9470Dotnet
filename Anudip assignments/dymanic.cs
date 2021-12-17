class Demo
{ 
 dynamic Data = 2; 
 public int Method(int A, int B) 
 { 
 return (A + B) * Data; 
 } 
} 
class Program 
{ 
 static void Main(string[] args) 
 { 
 DemoObj = newDemo(); 
 dynamic value1 = 5; 
 dynamic value2 = 4; 
 dynamic Str = "Your Result Is: "; 
 Console.WriteLine(Str + Obj.Method(value1, value2)); 
 Console.ReadLine(); 
 } 
} 
