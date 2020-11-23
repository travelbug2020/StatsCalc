using NUnit.Framework;

namespace StatsCalculator.Test
{
    public class StatsCalculatorShould
    {

        [TestCase(new[]{1,2,3},1)]
        [TestCase(new[]{4,5,6},4)]
        [TestCase(new[]{7,8,9},7)]
        public void ReturnMinimum_WhenSearchingForMinimum_GivenNumbers(int[] numbers,int minimum)
        {
            Assert.AreEqual(minimum,numbers.MinimumValue());
        }

        [TestCase(new int[]{5,8,3,2,10},10)]
        [TestCase(new int[]{1,2,3},3)]
        [TestCase(new int[]{4,5,6},6)]
        [TestCase(new int[]{7,8,9},9)]
        public void ReturnMaximum_WhenSearchingForMaximum_GivenNumbers(int[] numbers, int maximum)
        {
            Assert.AreEqual(maximum,numbers.MaximumValue());
        }

        [TestCase(new []{1,2,3,4},4)]
        [TestCase(new []{3,4,10,-2},4)]
        [TestCase(new []{-1,10,11,25,67},5)]
        public void ReturnCount_WhenSearchingForNumberOfElements_GivenNumbers(int[] numbers, int count)
        {
            var result = StatsCalc.NumberOfElements(numbers);

            Assert.AreEqual(count,result);
        }

        [TestCase(new []{10,20,30},20)]
        [TestCase(new []{6,-2,20,13},9.25)]
        [TestCase(new []{4,5,6,1,2,3},3.5)]
        public void ReturnAverage_WhenSearchingForAverage_GivenNumbers(int[] numbers, decimal average)
        {
            var result = StatsCalc.AverageValue(numbers);

            Assert.AreEqual(average,result);
        }
    }
}