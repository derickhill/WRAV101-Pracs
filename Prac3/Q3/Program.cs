using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Balance:");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Amount to be withrawn:");
            double amount = double.Parse(Console.ReadLine());

            if(amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                Console.WriteLine("New balance: {0}", balance - amount);
            }
        }
    }
}
