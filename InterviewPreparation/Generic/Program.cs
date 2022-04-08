using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generic
{
    //declare generics
    public class GenericClass<T>
    { public void Genericfunction(T printvalue)
    {
        Console.WriteLine(printvalue);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("printing integer values");
        GenericClass<int> i = new GenericClass<int>();
        i.Genericfunction(500);
        Console.WriteLine("printing string values");
        GenericClass<string> s = new GenericClass<string>();
        s.Genericfunction("Apoorva");
    }
}
    }