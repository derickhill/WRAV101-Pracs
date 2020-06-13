using System;

namespace Week5Tut
{
    class Program
    {
        static void Main(string[] args)
        {
            double maxAverage = Double.NegativeInfinity;
            int count = 0;
            
            for(int i = 1; i <= 5; i++)
            {
                Console.WriteLine("\nAthlete {0}:", i);
                
                double ave = getAverage();

                if(ave > 7)
                {
                    count++;
                }

                UpdateMax(ave, ref maxAverage);
            }

            Display(count, maxAverage);
        }

        static public int getValidScore()
        {
            int input;

            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    input = -1;
                }
            }
            while(input < 0 || input > 10);

            return input;
        }

        static public double getAverage()
        {
            int sum = 0;

            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Enter score {0}:", i);
                sum += getValidScore();
            }

            return sum/3.0;
        }

        static public void UpdateMax(double a, ref double max)
        {
            if(a > max)
            {
                max = a;
            }
        }

        static public void Display(int count, double max)
        {
            Console.WriteLine("Number average scores above 7: {0}\nHighest average score: {1}", count, max);
        }
    }
}
