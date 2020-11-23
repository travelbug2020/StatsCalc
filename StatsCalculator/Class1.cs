using System.Globalization;
using System.Linq;

namespace StatsCalculator
{
    public static class StatsCalc
    {
        public static int MinimumValue(this int[] listOfNumbers)
        {
            
            var smallestNumber = listOfNumbers[0]; 
            foreach (var number in listOfNumbers)
            {
                if (number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }

            return smallestNumber;
        }

        public static int MaximumValue(this int[] listOfNumbers)
        {
            var largestNumber = listOfNumbers[0];
            foreach (var number in listOfNumbers)
            {
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }

            return largestNumber;
        }

        public static int Count(this int[] listOfNumbers)
        {
            var count = 0;
            foreach (var number in listOfNumbers)
            {
                count+=1;
            }
            return count;
        }

        public static double AverageValue(this int[] listOfNumbers)
        {
            double numbersAddedTogether = 0;
            foreach (var number in listOfNumbers)
            {
                numbersAddedTogether += number;
            }

            var average = numbersAddedTogether / Count(listOfNumbers);
            return average;
        }
    }
}
