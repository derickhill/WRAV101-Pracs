using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Wage per hour:");
            double wage = double.Parse(Console.ReadLine());
            Console.WriteLine("Number of hours worked:");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Name\t\t: {0}\nWage/hour\t: {1:C}\nNo Hours\t: {2}\nTotal Wage\t: {3:C}", name, wage, hours, hours * wage);
        }
    }
}
