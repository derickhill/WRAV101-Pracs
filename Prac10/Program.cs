using System;

namespace Prac10
{
    class Program
    {
        static void Main(string[] args)
        {
            int bigFlights = 0;

            for(int i = 1; i <= 5; i++)
            {
                DoAnAirport(ref bigFlights);
            }

            Console.WriteLine("\nTotal incoming flights: {0}", bigFlights);
        }

        static public void GetAirportData(out String Name, out String City, out int nrInPlanes)
        {
            Console.WriteLine("Airport name:");
            Name = Console.ReadLine();
            Console.WriteLine("City:");
            City = Console.ReadLine();
            Console.WriteLine("Incoming planes:");
            nrInPlanes = getPositive();

        }

        static public int getPositive()
        {
            int posNo;

            do
            {
                posNo = int.Parse(Console.ReadLine());
            }
            while(posNo < 0);

            return posNo;
        }

        static void DoAnAirport (ref int countBig)
        {
            string Name, City;
            int inPlanes;

            GetAirportData(out Name, out City, out inPlanes);

            Console.WriteLine("Name\t: {0}\nCity\t: {1}\nIncoming planes: {2}", Name, City, inPlanes);

            countBig += inPlanes;
        }
    }
}
