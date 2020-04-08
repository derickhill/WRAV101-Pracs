using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] descrArr = new string[3];
            double[] priceArr = new double[3];

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter product description:");
                descrArr[i] = Console.ReadLine();
                Console.WriteLine("Enter product price:");
                priceArr[i] = double.Parse(Console.ReadLine());
            }

            double total = priceArr[0] + priceArr[1] + priceArr[2];    
            int bonus = (int) Math.Floor(total)/5;
            double vat = total * .14;
            double final = total + vat;

            Console.WriteLine("{0}\t{1:C}\n{2}\t{3:C}\n{4}\t{5:C}\nTotal\t{6:C}\nVAT\t{7:C}\nFinal\t{8:C}\n\nBonus Points: {9}", descrArr[0], priceArr[0], descrArr[1], priceArr[1], descrArr[2], priceArr[2], total, vat, final, bonus);            
                
       }
    }
}
