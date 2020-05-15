using System;

namespace Q1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 4; i > 0; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
