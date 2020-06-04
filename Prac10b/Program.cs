using System;

namespace Prac10b
{
    class Program
    {
        static void Main(string[] args)
        {
            double bestAverage = Double.PositiveInfinity;

            for(int i = 0; i < 10; i++)
            {   
                GetAthleteData(out string name, out int age, out double avgTime);
                AthleteDisplay(name, age, avgTime);
                bestAverage = getMin(bestAverage, avgTime);
            }

            FinalDisplay(bestAverage);
        }

        static public int getValidNumber(int low, int high)
        {
            int validNumber;

            do
            {
                try
                {
                    validNumber = int.Parse(Console.ReadLine());
                } 
                catch(FormatException)
                {
                    validNumber = low - 1;
                }
            } while(validNumber < low || validNumber > high);

            return validNumber;
        }

        static public double getMin(double a, double b)
        {
            if(a < b)
                return a;
            else
                return b;
        }

        static public void GetAthleteData(out string Name, out int Age, out double AvgTime)
        {
            Console.WriteLine("Athlete name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Athelete age: ");
            Age = getValidNumber(18, 35);

            AvgTime = GetAvgSprintTime();
        }

        static public double GetAvgSprintTime()
        {
            Console.WriteLine("Number of sprints: ");
            int numSprints = getValidNumber(5, 15);

            double sum = 0;

            for(int i = 0; i < numSprints; i++)
            {
                Console.WriteLine("Time for sprint {0}: ", i+1);
                double time = getValidNumber(10, 20);

                sum += time;
            }

            return sum/numSprints;
        }

        static void AthleteDisplay (String Name, int Age, double AvgTime)
        {
            Console.WriteLine("Name: {0}\nAge: {1}\nAverage time: {2}", Name, Age, AvgTime);
        }

        static void FinalDisplay (double BestTime)
        {
            Console.WriteLine("\nBest average: {0}", BestTime);
        }
    }
}
