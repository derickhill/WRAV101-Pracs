using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input1 = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                int input2 = int.Parse(Console.ReadLine());

                if(input2 > input1)
                {
                    input1 = input2;
                }
            }

            Console.WriteLine(input1);
        }
    }
}
