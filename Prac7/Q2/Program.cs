using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            while(input < 1 || input > 49)
            {
                Console.WriteLine("Enter a number:");
                input = int.Parse(Console.ReadLine());
            }

            for(int i = input; i > 1; i--)
            {
                if(i%2 == 0)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
