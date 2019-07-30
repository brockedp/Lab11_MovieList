using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11MovieList
{
    public class Movie
    {
        private string title;
        private string category;

        public string Title { get => title; set => title = value; }
        public string Category { get => category; set => category = value; }


        public Movie()
        {

        }
        public Movie(string title, string catergory)
        {
            this.title = title;
            this.category = catergory;
        }
        public static int TryParseInput(List<string> catList)
        {
            string input = Console.ReadLine();
            try
            {
                int userInput = int.Parse(input);
                userInput--;
                return userInput;

            }
            catch (FormatException)
            {
                input.ToLower();
                if (catList.Contains(input))
                {
                    int index = catList.IndexOf(input);
                    return index;
                }
                else
                {
                    Console.WriteLine("Please enter another input");
                    return TryParseInput(catList);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.GetType()}. Please enter another input");
                return TryParseInput(catList);
            }
        }
        public static bool PlayAgain(string message)
        {
            string input = "";
            while (input != "y" && input != "yes" && input != "n" && input != "no")
            {
                Console.Write(message);
                input = Console.ReadLine().ToLower();
            }

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void AddNewInput(string message, List<string> inputList)
        {
            string input = "  ";
            bool isEmpty = string.IsNullOrWhiteSpace(input);
            while (isEmpty)
            {
                input = Console.ReadLine();
                isEmpty = string.IsNullOrWhiteSpace(input);

            }
            inputList.Add(input);
        }

    }
}
