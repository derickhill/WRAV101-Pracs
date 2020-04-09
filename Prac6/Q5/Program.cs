using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many integers will be entered:");
            int no = int.Parse(Console.ReadLine());
            int sum = 0;

            if(no != 0)
            {
                for(int i = 0; i < no; i++)
                {
                    Console.WriteLine("Enter a number:");
                    int input = int.Parse(Console.ReadLine());

                    if(input > 50)
                        sum += input;
                }

                Console.WriteLine("Average: {0:F2}", sum/(no*1.0));
            }
        }
    }
}
