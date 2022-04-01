using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGeneric
{
	internal class Program
	{
		class GFG
		{

			// Driver code
			public static void Main(string[] args)
			{

				// Creating a Queue
				Queue myQueue = new Queue();

				// Inserting the elements into the Queue
				myQueue.Enqueue("payal");
				myQueue.Enqueue("pooja");
				myQueue.Enqueue("priya");
				myQueue.Enqueue("pranjali");
				myQueue.Enqueue("priti");

				// Displaying the count of elements
				// contained in the Queue
				Console.Write("Total number of elements present in the Queue are: ");

				Console.WriteLine(myQueue.Count);

				// Displaying the beginning element of Queue
				Console.WriteLine("Beginning Item is: " + myQueue.Peek());
			}
		}
	}
}

