using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 1;
            
            for(int i = 1; i < 100; i++)
            {
                if(i%2 != 0)
                {
                    total -= (i+1);
                }
                else
                {
                    total += (i+1);
                }
            }

            Console.WriteLine(total);
        }
    }
}
