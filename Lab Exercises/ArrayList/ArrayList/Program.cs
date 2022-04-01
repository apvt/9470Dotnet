using System;
using System.Collections;

class GFG
{

	// Main Method
	public static void Main(string[] args)
	{

		// Create a list of strings
		ArrayList al = new ArrayList();
		al.Add("Apoorva");
		al.Add("Shruti");
		al.Add(10);
		al.Add(10.10);

		// Iterate list element using foreach loop
		foreach (var names in al)
		{
			Console.WriteLine(names);
		}
	}
}
