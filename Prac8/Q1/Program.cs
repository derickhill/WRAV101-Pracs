using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Enter a number:");
                int input = int.Parse(Console.ReadLine());

                sum += input;
            }

            Console.WriteLine("Sum\t: {0}\nAverage\t: {1:F2}", sum, sum/(5*1.0));
        }
    }
}
