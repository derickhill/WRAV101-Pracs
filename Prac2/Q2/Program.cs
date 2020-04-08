using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no. of minutes:");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} minutes is {1} hours and {2} minutes", minutes, minutes/60, minutes%60);
        }
    }
}
