using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] markArr = new int[2];
            double avg;

            for(int i = 0; i <= 1; i++)
            {
                do
                {
                    Console.WriteLine("Enter mark {0}:", i+1);
                    try
                    {
                        markArr[i] = int.Parse(Console.ReadLine());
                    }
                    catch(System.FormatException)
                    {
                        Console.WriteLine("Please enter a valid mark.");
                        markArr[i] = -1;
                    }
                }
                while(markArr[i] < 0 || markArr[i] > 100);
            }

            avg = (markArr[0] + markArr[1])/2.0;

            Console.WriteLine("The average is: {0}", avg);
        }
    }
}
