using System;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Grade:");
            char grade = Console.ReadLine().ToUpper()[0];
            
            string range = "";

            switch(grade)
            {
                case 'A':
                    range = "75-100";
                    break;
                case 'B':
                    range = "50-74";
                    break;
                case 'C':
                    range = "40-49";
                    break;
                case 'D':
                    range = "20-39";
                    break;
                case 'E':
                    range = "0-19";
                    break;
                default:
                    range = "Invalid.";
                    break;
            }

            Console.WriteLine(range);
        }
    }
}
