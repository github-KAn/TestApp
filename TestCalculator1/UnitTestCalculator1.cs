using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace TestCalculator1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(2,3,5)]
        [TestCase(-2, -3, -5)]
        [TestCase(2, -3, -1)]
        [TestCase(-2, 3, 1)]
        public void Add_2Sobatky_TraRaTong(int x, int y, int tong)
        {
            Calculator calc=new Calculator();
            float res = calc.Add(x, y);
            Assert.That(res,Is.EqualTo(tong));
        }
        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero_ReturnOddNumbersUpToLimit()
        {
            Calculator calc = new Calculator();
            var result = calc.GetOddNumbers(5);
            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 } ) );
        }
    }
}