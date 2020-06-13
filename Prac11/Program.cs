using System;

namespace Prac11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tempArr = new int[10];
            
            read10Integers(tempArr);

            Display(tempArr);

            Console.WriteLine("Average temperature: {0} degrees Celsius", getAvgTemperature(tempArr));
        }

        static public int getValidTemperature()
        {
            int temp;

            do
            {
                Console.WriteLine("Enter temperature:");
                try
                {
                    temp = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    temp = 0;
                }
            }
            while(temp <= 0 || temp >= 45);

            return temp;
        }

        static public void Display(int[] list)
        {
            foreach(int i in list)
            {
                Console.WriteLine(i + " degrees Celsius");
            }
        }

        static public void read10Integers(int[] list)
        {
            for(int i = 0; i < list.Length; i++)
            {
                list[i] = getValidTemperature();
            }
        }

        static public double getAvgTemperature(int[] list)
        {
            int sum = 0;

            foreach(int i in list)
            {
                sum += i;
            }

            return sum/(list.Length * 1.0);
        }
    }
}
