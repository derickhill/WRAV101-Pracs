using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                int input = int.Parse(Console.ReadLine());

                if(input%6 == 0 && input > 15)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
