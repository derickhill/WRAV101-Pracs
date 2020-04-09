using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                int entry = int.Parse(Console.ReadLine());

                if(entry % 3 != 0)
                {
                    sum += entry;
                    count++;
                }
            }

            Console.WriteLine(sum/(count*1.0));
        }
    }
}
