using System;

namespace JP
{
    class Program
    {
        static void Main(string[] args)
        {
            double BestTime = 0;

            Console.WriteLine("how many athletes were there?");
            int ath = int.Parse(Console.ReadLine());
            for ( int y = 1;y<=ath;y++)
            {
                string Name;int Age; double AvgTime;
                GetAthleteData( out Name, out Age, out AvgTime);
                Console.WriteLine("avereage time was {0}", AvgTime);

            }
             FinalDisplay(BestTime);

        }
        //
        static public int getValidNumber(int low, int high)
        {
            int valid;
            do
            {
                valid = int.Parse(Console.ReadLine());
            } while (valid < low || valid > high);
            return valid;
        }
        // Returns a number in the range low to high (including low and high). 
        static public double getMin(double a, double b)
        {
           
            if (a > b) 
                return b;
            else
                return a;
        }
        // Takes in two doubles, and returns the smallest of the two. 
        static public void GetAthleteData(out String Name, out int Age, out double AvgTime)
        {
            Console.WriteLine("enter the athletes name");
            Name = Console.ReadLine();
            Console.WriteLine("How old is {0}", Name);
            Age = getValidNumber(18,25);
            Console.WriteLine("what is {0}'s average sprint time", Name );
            AvgTime = GetAvgSprintTime();


        }
        // Returns the following information about an athlete, after getting  
        // input from the user: Name, Age, Average Sprint Time 
        // Note: The age must be in the range 18 to 35. 

        static public double GetAvgSprintTime()
        {
             double numS;
            double timeS; 
            double sumTime= 0;
            
            Console.WriteLine("how many sprints did they do?");
            numS = getValidNumber(5, 15);
            for (int x = 1; x <= numS; x++)
            {
                Console.WriteLine("What was the time for  sprint ");
                timeS = getValidNumber(10, 20);
                
                sumTime = timeS+ sumTime;
            }
            Console.WriteLine();
            double avg = sumTime / numS;
            return avg;
        }

        // First requests from the user how many sprints the athlete did. It  
        // then reads in the times (in seconds) for each sprint, after which 
        // the average time is calculated and returned. 
        // Note: Times read in must be in the range 10 to 20. 
        //       All athletes did between 5 and 15 sprints.

        static void AthleteDisplay(String Name, int Age, double AvgTime)
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(AvgTime);

        }
            
           // Takes as input the name, age and average time of the athlete,  
           // and displays on the screen. 


        static void FinalDisplay(double BestTime)
        {
            Console.WriteLine(BestTime);
            if (GetAvgSprintTime()>BestTime)
            {
                BestTime = GetAvgSprintTime();
            }
            Console.WriteLine("the best avg time was..");
            Console.WriteLine(BestTime);
        }
            // Takes as input the best average time of all the athletes, and  
            // displays it on the screen. 

    }
}
