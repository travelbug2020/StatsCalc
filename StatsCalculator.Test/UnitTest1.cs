using NUnit.Framework;

namespace StatsCalculator.Test
{
    public class StatsCalculatorShould
    {
        private StatsCalc _calculator;
        
        [SetUp]
        public void SetUp()
        {
            _calculator = new StatsCalc();
        }

        [TestCase(new[]{1,2,3},1)]
        [TestCase(new[]{4,5,6},4)]
        [TestCase(new[]{7,8,9},7)]
        public void ReturnMinimum_WhenSearchingForMinimum_GivenNumbers(int[] numbers,int minimum)
        {
            var result = _calculator.MinimumValueFrom(numbers);

            Assert.AreEqual(minimum,result);
        }
        [TestCase(new int[]{5,8,3,2,10},10)]
        [TestCase(new int[]{1,2,3},3)]
        [TestCase(new int[]{4,5,6},6)]
        [TestCase(new int[]{7,8,9},9)]
        
        public void ReturnMaximum_WhenSearchingForMaximum_GivenNumbers(int[] numbers, int maximum)
        {
            var result = _calculator.MaximumValueFrom(numbers);

            Assert.AreEqual(maximum,result);
        }

        [Test]
        public void ReturnNumberOfElementsIs4When1234()
        {
            
            
            var result = _calculator.NumberOfElements(1, 2, 3, 4);
            
            Assert.AreEqual(4, result);
        }

        [Test]
        public void ReturnNumberOfElementsIs2When3410Neg2()
        {
            
            
            var result = _calculator.NumberOfElements(3, 4, 10, -2);
            
            Assert.AreEqual(4,result);
        }
        [Test]
        public void ReturnNumberOfElementsIs5()
        {
            
            
            var result = _calculator.NumberOfElements(-1, 10, 11, 25, 67);
            
            Assert.AreEqual(5, result);
        }

        [Test]
        public void ReturnAverageValue20WhenGiven102030()
        {
            
            
            var result = _calculator.AverageValue(10, 20, 30);
            
            Assert.AreEqual(20, result);
        }

        [Test]
        public void ReturnAverageValue9Point23WhenGiven6Neg22013()
        {
            
            
            var result = _calculator.AverageValue(6, -2, 20, 13);
            
            Assert.AreEqual(9.25, result);
        }

        [Test]
        public void ReturnAverageValue3Point5WhenGiven6Neg22013()
        {
            
            
            var result = _calculator.AverageValue(4, 5, 6, 1, 2, 3);
            
            Assert.AreEqual(3.5, result);
        }

    }
}