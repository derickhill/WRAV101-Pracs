using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = -1;

            for(int i = 0; i <= 5; i++)
            {
                while(input < 0 || input > 100)
                {
                    Console.WriteLine("Enter a number:");
                    input = int.Parse(Console.ReadLine());
                }    
                sum += input;
                input = -1;
            }

            Console.WriteLine("Sum\t: {0}\nAverage\t: {1:F2}", sum, sum/(5*1.0));
        }
    }
}
