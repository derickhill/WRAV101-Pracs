using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            int noMovies, topScore;
            
            string topMovie = "";

            topScore = 0;

            Console.WriteLine("Enter the number of movies to be scored:");
            noMovies = int.Parse(Console.ReadLine());

            for(int i = 0; i < noMovies; i++)
            {
                Console.WriteLine("Enter movie {0}'s name:", i+1);
                string movieName = Console.ReadLine();
                
                int sum = 0;

                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter score {0}:", j+1);
                    sum += int.Parse(Console.ReadLine());
                }

                if(sum > topScore)
                {
                    topMovie = movieName;
                    topScore = sum;
                }
            }

            Console.WriteLine("The movie with the highest score is {0}.", topMovie);

            
            
        }
    }
}
