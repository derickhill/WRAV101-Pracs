using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int noStudents;
            int fiftyCount = 0;
            
            do
            {
                Console.WriteLine("Enter the number of students: ");
                noStudents = int.Parse(Console.ReadLine());
            }
            while(noStudents <= 0);

            for(int i = 0; i < noStudents; i++)
            {
                int marks = 0;

                for(int j = 1; j <= 3; j++)
                {
                    Console.WriteLine("Enter mark {0}: ", j);
                    marks += int.Parse(Console.ReadLine());
                }

                double average = marks/3.0;

                Console.WriteLine("Average: {0}\n", average);

                if(average > 50)
                {
                    fiftyCount++;
                }
            }

            Console.WriteLine("\n{0} students had an average mark of above 50.", fiftyCount);

        }
    }
}
