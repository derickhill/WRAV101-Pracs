using System;

namespace Q1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 4; i > 0; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
