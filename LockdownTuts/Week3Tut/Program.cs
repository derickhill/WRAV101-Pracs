using System;

namespace Week3Tut
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, product, min, max;
            
            first = GetEvenNumber();
            second = GetEvenNumber();

            product = GetProduct(first, second);

            GetMinMax(first, second, out min, out max);

            Display(product, min, max);
        }

        static public int GetProduct(int a, int b)
        {
            return a * b;
        }

        static public void GetMinMax(int a, int b, out int min, out int max)
        {
            if(a > b)
            {
                min = b;
                max = a;
            }
            else
            {
                min = a;
                max = b;
            }
        }

        static public int GetEvenNumber()
        {
            int input;

            do
            {
                Console.WriteLine("Enter an even integer:");

                try
                {
                    input = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter valid numeric characters only.");
                    input = 1;
                }
            }
            while(input % 2 != 0);

            return input;
        }

        static public void Display (int product, int min, int max)
        {
            Console.WriteLine("Min:\t{0}\nMax:\t{1}\nProduct: {2}", min, max, product);
        }
    }
}
