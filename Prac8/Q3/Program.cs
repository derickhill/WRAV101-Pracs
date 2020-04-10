using System;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int input = -1;
            int fiddyCount = 0;

            for(int i = 0; i <= 5; i++)
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

            Console.WriteLine("Sum\t\t: {0}\nAverage\t\t: {1:F2}\nMarks above 50\t: {2}", sum, sum/(5*1.0), fiddyCount);
        }
    }
}
