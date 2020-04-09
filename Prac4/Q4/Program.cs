using System;

namespace Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No. of month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Year:");
            int year = int.Parse(Console.ReadLine());

            string wordMonth = "";
            int days = 0;

            switch(month)
            {
                case 1:
                    wordMonth = "January";
                    days = 31;
                    break;
                case 2:
                    wordMonth = "February";
                    if(year%4 == 0)
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
                case 3:
                    wordMonth = "March";
                    days = 31;
                    break;
                case 4:
                    wordMonth = "April";
                    days = 30;
                    break;
                case 5:
                    wordMonth = "May";
                    days = 31;
                    break;
                case 6:
                    wordMonth = "June";
                    days = 30;
                    break;
                case 7:
                    wordMonth = "July";
                    days = 31;
                    break;
                case 8:
                    wordMonth = "August";
                    days = 31;
                    break;
                case 9:
                    wordMonth = "September";
                    days = 30;
                    break;
                case 10:
                    wordMonth = "October";
                    days = 31;
                    break;
                case 11:
                    wordMonth = "November";
                    days = 30;
                    break;
                case 12:
                    wordMonth = "December";
                    days = 31;
                    break;
                default:
                    wordMonth = "Error";
                    break;
            }

            Console.WriteLine("{0}: {1}", wordMonth, days);
        }
    }
}
