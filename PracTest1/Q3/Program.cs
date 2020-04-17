using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 5; i > 2; i--)
            {
                for(int j = i; j > 0; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
