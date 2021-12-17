using System;


class Demo
{
    dynamic Data = 20;
    public int Method(int X, int Y)
    {
        return (X + Y) * Data;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Demo Obj = new Demo();
        dynamic value1 = 51;
        dynamic value2 = 6;
        dynamic Str = "Your Result Is: ";
        Console.WriteLine(Str + Obj.Method(value1, value2));
        Console.ReadLine();
    }
}