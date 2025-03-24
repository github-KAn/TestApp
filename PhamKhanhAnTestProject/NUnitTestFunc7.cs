using PhamKhanhAnExamples;
using NUnit.Framework;
namespace PhamKhanhAnUnitTestExamples;
[TestFixture]
public class NUnitTestFunc7
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    [TestCase(501 , 501, true, 70 )]
    [TestCase(201, 501, false, 30)]
    [TestCase(200, 0, true, 10)]
    public void TestFunc7Paramterized(int a, int b, bool c,int res)
    {
        //Arrange
        var func71 = new Func71();
        int result = func71.Func7(a, b, c);
        Assert.That(result, Is.EqualTo(res));
    }
}
