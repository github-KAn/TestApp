
namespace UnitTestCalculatorSumSub;
[TestClass]
public class TestCalculatorSumSub
{
    [TestMethod]
    public void Add_2SoDuong_Sum()
    {
        Calculator calc=new Calculator();
        int res = calc.Add(2,3);
        int ex_res = 4;
        Assert.AreEqual(res, ex_res);
    }

    [Test]
    public void Add_2SoAm_Sum()
    {
        Calculator calc = new Calculator();
        int res = calc.Add(-2, -3);
        int ex_res = 4;
        Assert.AreEqual(res, ex_res);
    }
}