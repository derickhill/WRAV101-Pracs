using System;

namespace EMA
{
    class Program
    {
        static int[] list = new int[10];
        static int NrEl = 0;
        static void Main(string[] args)
        {
            ReadMarksIntoArray(list, ref NrEl);
            
            displayGoodMarks(list, NrEl);
        }

        static public int getValidNumber(int a, int b)
        {
            int nr;
            do
            {
                try
                {
                    nr = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    nr = a - 1;
                }
            }
            while(nr > b || nr < a);

            return nr;
        }

        static public void ReadMarksIntoArray (int[] list, ref int NrEl)
        {
            Console.WriteLine("How many marks need to be read in?");

            int noMarks = getValidNumber(0, 10);

            for(int i = 0; i < noMarks; i++)
            {
                Console.WriteLine("Mark {0}:", i+1);
                list[NrEl] = getValidNumber(0, 100);
                NrEl++;
            }
        }

        static public double getAverage(int[] list, int NrEl)
        {
            int sum = 0;

            for(int i = 0; i < NrEl; i++)
            {
                sum += list[i];
            }

            return sum/(NrEl*1.0);
        }

        static public void displayGoodMarks (int[] list, int NrEl)
        {
            double ave = getAverage(list, NrEl);

            Console.WriteLine("Marks above average:");

            for(int i = 0; i < NrEl; i++)
            {
                if(list[i] > ave)
                {
                    Console.WriteLine(list[i]);
                }
            }
        }
    }
}
