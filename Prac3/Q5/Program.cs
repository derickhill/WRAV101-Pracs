using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lawn length:");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Lawn width:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;

            double fee = 0;

            if(area < 400)
            {
                fee = area;
            }
            else
            {
                fee = area * .8;
            }

            Console.WriteLine("Fee: {0:C}", fee);
        }
    }
}
