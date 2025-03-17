
using Microsoft.VisualStudio.TestPlatform.ObjectModel;

namespace UnitTestCalculatorSumSub
{
    [TestClass]
    public class TestCalculatorParameter
    {
        [TestMethod]
        [TestCategory("2,3,5")]
        [TestCategory("-2,-3,-5")]
        public void Add_2SoDuong_Sum()
        {
            Calculator calc = new Calculator();
            int res = calc.Add(2, 3);
            int ex_res = 5;
            Assert.AreEqual(res, ex_res);
        }
        [TestMethod]
        public void Add_2SoAm_Sum()
        {
            Calculator calc = new Calculator();
            int res = calc.Add(-2, -3);
            int ex_res = -5;
            Assert.AreEqual(res, ex_res);
            
        }
        
    }
}
