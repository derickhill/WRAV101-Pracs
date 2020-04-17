using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of seconds:");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine("Total seconds - {0} seconds\nHours\t: {1}\nMinutes\t: {2}\nSeconds\t: {3}", seconds, seconds/3600, (seconds%3600)/60, (seconds%3600)%60);
        }
    }
}
