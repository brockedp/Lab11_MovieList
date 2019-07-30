using System;
using System.Collections.Generic;

namespace Lab11MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>
            {
                new Movie("The Rugrats Movie","Animated"),
                new Movie("Star Wars: New Hope", "SciFi"),
                new Movie("Saw", "Horror"),
                new Movie("Ex Machina","Scifi"),
                new Movie("No Country for Old Men","Drama"),
                new Movie("Final Destination", "Horror"),
                new Movie("Coco","Animated"),
                new Movie("Chappie", "Scifi"),
                new Movie("The Hateful Eight", "Drama"),
                new Movie("Youngblood","Drama")
            };
            List<string> movieCategory = new List<string> { "drama", "scifi", "horror", "animated" };

            Console.WriteLine("Welcome to the Movie List Application!");
            bool again = true;
            while (again)
            {
                Console.WriteLine("What category are you interested in:" );
                for(int i = 0; i < movieCategory.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {movieCategory[i]}");
                }
                int userInput = Movie.TryParseInput(movieCategory);
                Console.WriteLine("------");
                try
                {
                    string titleCatergory = movieCategory[userInput];
                    foreach (Movie item in movieList)
                    {
                        if (item.Category.ToLower() == titleCatergory)
                        {
                            Console.WriteLine(item.Title);

                        }
                    }

                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("That number is out of range");

                    
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.GetType()}: {e.Message}");
                }


                Console.WriteLine("------");
                again = Movie.PlayAgain("Would you like to view other categories?(y/n): ");
                Console.Clear();


            }
            Console.WriteLine("Good Bye");
        }

       


    }
}
