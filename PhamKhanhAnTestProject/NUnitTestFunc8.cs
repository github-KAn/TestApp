using PhamKhanhAnExamples;
using NUnit.Framework;
namespace PhamKhanhAnUnitTestExamples;

public class NUnitTestFunc8
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(501,false,true,70)]
    [TestCase(149, true, false, 40)]
    public void TestFunc8Parameterized(int a, bool b, bool c, int result)
    {
        var func8 = new Func81();
        int res = func8.Func8(a, b, c);
        Assert.That(res, Is.EqualTo(result));
    }
}
