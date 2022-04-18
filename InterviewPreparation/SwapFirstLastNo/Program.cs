using System;

namespace SwapFirstLastNo
{
     class Program
    {
        static void Main(string[] args)
        {
            int num, last, first, temp, count = 0;
            double swap;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;
            last = temp % 10;
            count = (int)Math.Log10(temp);

            while (temp >= 10)
            {
                temp /= 10;
            }
            first = temp;
            swap = (last * Math.Pow(10, count) + first) + (num - (first * Math.Pow(10, count) + last));

            Console.WriteLine("Last Digit:" + last);

            Console.WriteLine("First Digit:" + first);

            Console.WriteLine(num + " is swapped to " + swap);

            Console.ReadLine();
        }
    }
}
	
