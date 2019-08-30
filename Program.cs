using System;
using System.Linq;

namespace FindLowestNumber
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a list of numbers with no spaces in between: ");
            var number = Console.ReadLine();

            Console.Write("Enter the number of characters which should be removed: ");
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GenerateLowestNumber(number, n));
        }
        public static string GenerateLowestNumber(string number, int n)
        {
            var listOfInts = number.Select(numbers => int.Parse(numbers.ToString())).ToList();
            var numbersOfListPositionsToExclude = listOfInts.Count - n;
            var outputString = "The lowest number which can be created is: ";

            for (int i = 0; i < numbersOfListPositionsToExclude; i++)
            {
                var tempListOfInts = listOfInts.Take(listOfInts.Count - (numbersOfListPositionsToExclude - 1 - i));

                outputString += tempListOfInts.Min();
                listOfInts.RemoveRange(0, listOfInts.IndexOf(tempListOfInts.Min()) + 1);
            }

            return outputString;
        }
    }
}
