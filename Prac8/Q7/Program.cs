using System;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int noStudents = int.Parse(Console.ReadLine());
            
            int sum = 0;
            int input = -1;
            int fiddyCount = 0;
            double highestAverage = 0;
            string highestName = "";

            for(int i = 0; i < noStudents; i++)
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                for(int j = 0; j < 5; j++)
                {
                    while(input < 0 || input > 100)
                    {
                        Console.WriteLine("Enter a number:");
                        input = int.Parse(Console.ReadLine());
                    }    

                    if(input >= 50)
                        fiddyCount++;

                    sum += input;
                    input = -1;
                }
                Console.WriteLine("Name\t\t: {0}\nSum\t\t: {1}\nAverage\t\t: {2:F2}\nMarks above 50\t: {3}", name, sum, sum/(5*1.0), fiddyCount);
                Console.WriteLine();

                if(sum/(5*1.0) > highestAverage)
                {
                    highestAverage = sum/(5*1.0);
                    highestName = name;
                }

                sum = 0;
            }
            Console.WriteLine();
            Console.WriteLine("Highest average\t: {0}, {1:F2}", highestName, highestAverage);
        }
    }
}
