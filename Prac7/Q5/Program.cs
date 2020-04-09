using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = 2;
            int count = 0;

            while(population <= 100)
            {
                    if(population%2 == 0)
                    {
                        population = (int) Math.Round(population * 1.5);
                    }
                    else
                    {
                        population = population * 2;
                    }

                    if(count%4 == 0)
                    {
                        population -= 2;
                    }

                    count++;
            }

            Console.WriteLine("Weeks: {0}\nPopulation: {1}", count, population);
        }
    }
}
