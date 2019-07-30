using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11MovieList
{
    class Validator
    {
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
