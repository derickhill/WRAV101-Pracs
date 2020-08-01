using System;

namespace Week6Tut
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salesArr = new int[10];
            int NrEl = 0;

            Console.WriteLine("How many salesmen sold masks this week?");
            int noSalesmen = getPositiveNumber();

            for(int i = 0; i < noSalesmen; i++)
            {
                ReadSalesIntoArray(salesArr, ref NrEl);
            }

            Display(salesArr, NrEl);

            DisplayStatement(getSum(salesArr, NrEl));
        }

        static public int getPositiveNumber()
        {
            int input;

            do
            {
                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    input = 0;
                }
            }
            while(input <= 0);

            return input;
        }

        static public void ReadSalesIntoArray (int[] list, ref int NrEl)
        {
            Console.WriteLine("Number of masks for salesman {0}:", NrEl+1);
            list[NrEl] = getPositiveNumber();
            NrEl++;
        }

        static public void Display(int[] list, int NrEl)
        {
            for(int i = 0; i < NrEl; i++)
            {
                Console.WriteLine("Agent {0}: {1} masks", i+1, list[i]);
            }
        }

        static public int getSum (int[] list, int NrEl)
        {
            int sum = 0;
            
            for(int i = 0; i < NrEl; i++)
            {
                sum += list[i];
            }

            return sum;
        }

        static public void DisplayStatement(int TotalMasks)
        {
            Console.WriteLine("Total masks sold: {0}\nTotal income: {1:C}", TotalMasks, TotalMasks * 20.0);
        }

        
    }
}
