using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            double piePrice = 11.5;
            double burgerPrice = 35;
            
            Console.WriteLine("No. of pies:");
            int numPies = int.Parse(Console.ReadLine());
            Console.WriteLine("No. of hamburgers:");
            int numBurgers = int.Parse(Console.ReadLine());

            double total = numPies * piePrice + burgerPrice * numBurgers;

            Console.WriteLine("Your total is {0:C}.\nEnter amount paid:", total);
            double amountPaid = double.Parse(Console.ReadLine());

            double actualChange = amountPaid - total;

            int change = (int) Math.Floor(amountPaid - total);

            int fiddy = 0;

            if(actualChange - change == .5)
                fiddy = 1;

            Console.WriteLine("Change:{0:C}\n{1} x R100\n{2} x R50\n{3} x R20\n{4} x R10\n{5} x R5\n{6} x R2\n{7} x R1\n{8} x 50c", actualChange, change/100, change%100/50, change%100%50/20, change%100%50%20/10, change%100%50%20%10/5, change%100%50%20%10%5/2, change%100%50%20%10%5%2/1, fiddy);
        }
    }
}
