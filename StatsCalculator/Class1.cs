using System;
using System.Linq;

namespace StatsCalculator
{
    public class StatsCalc
    {

        public int MinimumValueFrom(int[] listOfNumbers)
        {
            return listOfNumbers.Min();
        }

        public int MaximumValueFrom(int[] listOfNumbers)
        {
            return listOfNumbers.Max();
        }
    }
}
