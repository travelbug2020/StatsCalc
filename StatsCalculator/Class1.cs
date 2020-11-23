using System;
using System.Linq;

namespace StatsCalculator
{
    public class StatsCalc
    {
        public int MinimumValueFrom(params int[] listOfNumbers)
        {
            return listOfNumbers.Min();
        }

        public int MaximumValueFrom(params int[] listOfNumbers)
        {
            return listOfNumbers.Max();
        }

        public int NumberOfElements(params int[] listOfNumbers)
        {
            return listOfNumbers.Length;
        }

        public double AverageValue(params int[] listOfNumbers)
        {
            return listOfNumbers.Average();
        }
    }
}
