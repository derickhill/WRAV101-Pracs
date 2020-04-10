using System;

namespace Prac9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of modules:");
            int noModules = GetAPositiveNumber();

            for(int i = 0; i < noModules; i++)
            {
                string maxStudent = "";
                double max = 0;
                
                Console.WriteLine("Enter module name:");
                string module = Console.ReadLine();
                
                Console.WriteLine("Enter number of students:");
                int noStudents = GetAPositiveNumber();

                for(int j = 0; j < noStudents; j++)
                {
                    Console.WriteLine("Enter name of student:");
                    string student = Console.ReadLine();
                    
                    int[] markArr = GetTwoMarks();

                    double average = GetAverage(markArr[0], markArr[1]);

                    max = GetMax(average, max);

                    if(max == average)
                        maxStudent = student;
                }

                Console.WriteLine(DisplayReport(module, maxStudent));
            }
        }

        static public int GetAPositiveNumber()
        {
            int input = -1;
            
            while(input < 0)
            {
                input = int.Parse(Console.ReadLine());
            }

            return input;
        }

        static public int[] GetTwoMarks()
        {
            int input1 = -1;
            int input2 = -1;
            
            while(input1 < 0 || input1 > 100)
            {
                Console.WriteLine("Enter mark 1:");
                input1 = int.Parse(Console.ReadLine());
            }
            while(input2 < 0 || input2 > 100)
            {
                Console.WriteLine("Enter mark 2:");
                input2 = int.Parse(Console.ReadLine());
            }

            int[] inputArr = new int[2];

            inputArr[0] = input1;
            inputArr[1] = input2;

            return inputArr;
        }

        static public double GetAverage(int a, int b)
        {
            return (a + b)/2.0;
        }

        static public double GetMax(double a, double b)
        {
            if(a > b)
                return a;
            else
                return b;
        }

        static public string DisplayReport(string moduleName, string highestName)
        {
            return "Module\t\t: " + moduleName + "\nTop student\t: " + highestName;
        }
    }
}
