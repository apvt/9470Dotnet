using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.IO;

class program
{
static void Main(string[] args)
{
    FileInfo file = null;
    try
    {
        Console.Write("Enter a file name to write: ");
        string fileName = Console.ReadLine();
        file = new FileInfo(fileName);
        File.AppendText("Hello World!");
    }
    
    catch (Exception ex)
    {
        Console.WriteLine("Error occurred: {0}", ex.Message);
    }
    finally
    {
     
        file = null;
    }
}
}
