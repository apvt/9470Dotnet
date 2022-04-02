using System;

namespace percentagevalue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, percentage, option;
            float result;

        label:
            Console.Write("\nEnter number:\t");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter Percentage Value:\t");
            percentage = Convert.ToInt32(Console.ReadLine());

            result = (float)(num * percentage) / 100;
            Console.WriteLine("Percentage value is:\t{0}", result);
            Console.Write("\nCalculate again press 1");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                goto label;
            }
            Console.ReadLine();
        }
    }
}
