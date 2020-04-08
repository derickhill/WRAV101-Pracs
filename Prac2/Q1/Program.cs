using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 integers:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int  sum = a + b + c + d;
            double avg = sum/4.0;

            Console.WriteLine("The sum of the four integers is {0} and the average is {1}.", sum, avg);
        }
    }
}
