using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string loop = "";

            for(int i = 1; i < 15; i++)
            {
                loop += i + " ";
            }

            Console.WriteLine(loop);
        }
    }
}
