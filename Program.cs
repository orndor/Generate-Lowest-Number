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
            var iterator = listOfInts.Count - n;
            var outputString = "The lowest number which can be created is: ";

            for (int i = 0; i < iterator; i++)
            {
                var tempList = listOfInts.Take(listOfInts.Count - (iterator - 1 - i));
                var lowestUsableNum = tempList.Min();
                var indexOfLowestUsableNum = listOfInts.IndexOf(tempList.Min());

                listOfInts.RemoveRange(0, indexOfLowestUsableNum + 1);
                outputString += lowestUsableNum;
            }

            return outputString;
        }
    }
}
