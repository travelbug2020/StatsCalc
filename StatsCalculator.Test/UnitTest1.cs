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

        
    }
}