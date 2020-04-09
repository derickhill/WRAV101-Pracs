using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            int allTimeMax = 0;
            string maxName = "";
            
            for(int i = 1; i <= 15; i++)
            {
                int input = -1;
                int max = 0;
                
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                
                for(int j = 1; j <= 3; j++)
                {
                    while(input < 0 || input > 100)
                    {
                        Console.WriteLine("Enter mark:");
                        input = int.Parse(Console.ReadLine());
                    }

                    if(input > max)
                    {
                        max = input;
                    }

                    input = -1;
                }

                Console.WriteLine("Name: {0}\nMaximum mark: {1}", name, max);

                if(max > allTimeMax)
                {
                    allTimeMax = max;
                    maxName = name;
                }
                    

            }

            Console.WriteLine("All time max: {0}, {1}", maxName, allTimeMax);
        }
    }
}
