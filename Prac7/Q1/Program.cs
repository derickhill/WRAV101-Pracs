using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            while(input < 1 || input > 100)
            {
                Console.WriteLine("Enter a number:");
                input = int.Parse(Console.ReadLine());
            }

            if(input < 40)
            {
                Console.WriteLine("Fail.");
            }
            else
            {
                Console.WriteLine("Pass.");
            }
        }
    }
}
