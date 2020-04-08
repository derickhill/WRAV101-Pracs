using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Distance (km):");
            double distance = double.Parse(Console.ReadLine());
            Console.WriteLine("Fuel consumption (l):");
            double consumption = double.Parse(Console.ReadLine());
            Console.WriteLine("Cost of fuel per litre:");
            double cost = double.Parse(Console.ReadLine());

            Console.WriteLine("Cost of fuel: {0:C}\n{1:F2} km/litre\n{2:F2} litres/100km", cost*distance, distance/consumption, consumption/(distance/100));
        }
    }
}
