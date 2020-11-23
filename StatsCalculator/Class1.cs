using System.Linq;

namespace StatsCalculator
{
    public static class StatsCalc
    {
        public static int MinimumValue(this int[] listOfNumbers)
        {
            return listOfNumbers.Min();
        }

        public static int MaximumValue(this int[] listOfNumbers)
        {
            return listOfNumbers.Max();
        }

        public static int NumberOfElements(params int[] listOfNumbers)
        {
            return listOfNumbers.Length;
        }

        public static double AverageValue(params int[] listOfNumbers)
        {
            return listOfNumbers.Average();
        }
    }
}
