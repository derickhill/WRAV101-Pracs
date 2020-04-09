using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salary:");
            double salary = double.Parse(Console.ReadLine());

            if(salary < 2000)
            {
                Console.WriteLine("You do not pay tax, and your final payout is {0:C}", salary);
            }
            else
            {
                Console.WriteLine("Percentage tax:");
                double tax = double.Parse(Console.ReadLine())/100;

                Console.WriteLine("You pay {0:C} tax, and your final payout is {1:C}", tax*salary, salary - tax*salary);
            }
        }
    }
}
