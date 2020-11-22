using System.Reflection;
using NUnit.Framework;

namespace StatsCalculator.Test
{
    public class StatsCalculatorShould
    {

        [Test]
        public void ReturnMinimumNumber1WhenGiven123()
        {
            var calculator = new StatsCalc();
            var result = calculator.MinimumValueFrom(new int[] { 1, 2, 3});
            Assert.AreEqual(1,result);
        }

        [Test]
        public void ReturnMinimumNumber4WhenGiven456()
        {
            var calculator = new StatsCalc();
            var result = calculator.MinimumValueFrom(new int[] { 4, 5, 6});
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ReturnMinimumNumber7WhenGiven789()
        {
            var calculator = new StatsCalc();
            var result = calculator.MinimumValueFrom(new int[] {7,8,9});
            Assert.AreEqual(7,result);
        }

        [Test]
        public void ReturnMaximumNumber10WhenGiven583210()
        {
            var calculator = new StatsCalc();
            var result = calculator.MaximumValueFrom(new int[] { 8, 3, 5,2,10 });
            Assert.AreEqual(10, result);
        }

        [Test]
        public void ReturnMaximumNumber3WhenGiven123()
        {
            var calculator = new StatsCalc();
            var result = calculator.MaximumValueFrom(new int[]{1,2,3});
            Assert.AreEqual(3,result);
        }

        [Test]
        public void ReturnMaximumNumber6WhenGiven456()
        {
            var calculator = new StatsCalc();
            var result = calculator.MaximumValueFrom(new int[]{4,5,6});
            Assert.AreEqual(6,result);
        }

        [Test]
        public void ReturnMaximumNumber9WhenGiven789()
        {
            var calculator = new StatsCalc();
            var result = calculator.MaximumValueFrom(new int[] {7,8,9});
            Assert.AreEqual(9,result);
        }

        [Test]
        public void ReturnNumberOfElementsIs4When1234()
        {
            var calculator = new StatsCalc();
            var result = calculator.NumberOfElements(new int[] {1,2,3,4});
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ReturnNumberOfElementsIs2When3410Neg2()
        {
            var calculator = new StatsCalc();
            var result = calculator.NumberOfElements(new int[] {3,4,10,-2});
            Assert.AreEqual(4,result);
        }
        [Test]
        public void ReturnNumberOfElementsIs5()
        {
            var calculator = new StatsCalc();
            var result = calculator.NumberOfElements(new int[] { -1, 10, 11,25,67 });
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ReturnAverageValue20WhenGiven102030()
        {
            var calculator = new StatsCalc();
            var result = calculator.AverageValue(new int[] { 10, 20, 30});
            Assert.AreEqual(20, result);
        }

        [Test]
        public void ReturnAverageValue9Point23WhenGiven6Neg22013()
        {
            var calculator = new StatsCalc();
            var result = calculator.AverageValue(new int[] { 6, -2, 20, 13 });
            Assert.AreEqual(9.25, result);
        }

        [Test]
        public void ReturnAverageValue3Point5WhenGiven6Neg22013()
        {
            var calculator = new StatsCalc();
            var result = calculator.AverageValue(new int[] { 4, 5, 6, 1, 2, 3 });
            Assert.AreEqual(3.5, result);
        }

    }
}