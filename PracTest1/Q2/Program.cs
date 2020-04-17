using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("AS score:");
            int asScore = int.Parse(Console.ReadLine());

            if(asScore >= 450)
            {
                Console.WriteLine("Admitted.");
            }
            else
            {
                Console.WriteLine("Maths mark:");
                int maths = int.Parse(Console.ReadLine());

                if(maths >= 75)
                {
                    Console.WriteLine("Admitted.");
                }
                else
                {
                    Console.WriteLine("Not admitted.");
                }
            }
        }
    }
}
