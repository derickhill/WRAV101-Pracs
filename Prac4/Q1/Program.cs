using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());

            if(age < 50)
            {
                Console.WriteLine("You do not receive a subsidy.");
            }
            else
            {
                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine());

                if(salary < 2000)
                {
                    Console.WriteLine("Your salary is {0:C} and you receive a subsidy of {1:C}.", salary, salary * .15);
                }
                else
                {
                    Console.WriteLine("Your salary is {0:C} and you do not receive a subsidy.", salary);
                }
            }
        }
    }
}
