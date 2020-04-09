using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IQ score:");
            int iq = int.Parse(Console.ReadLine());

            if(iq < 0 || iq > 200)
            {
                Console.WriteLine("Error.");
            }
            else if(iq < 100)
            {
                Console.WriteLine("Below average.");
            }
            else if(iq == 100)
            {
                Console.WriteLine("Average.");
            }
            else
            {
                Console.WriteLine("Above average.");
            }
        }
    }
}
