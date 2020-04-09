using System;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            bool prime = true;

            double limit = Math.Sqrt(input*1.0);
            if(input == 1)
            {
                prime = false;
            }
            else
            {
                for(int i = 2; i < limit; i++)
                {
                    if(i != input && input%i == 0)
                    {
                        prime = false;
                    }
                }

            }
            if(prime)
                Console.WriteLine("Prime.");
            else
                Console.WriteLine("Not prime.");


            
        }
    }
}
