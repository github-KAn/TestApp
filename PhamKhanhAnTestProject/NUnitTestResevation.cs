using PhamKhanhAnExamples;

namespace PhamKhanhAnUnitTestExamples;
[TestFixture]
public class NUnitTestResevation
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Can_Be_Cancelled_ByAdmin_IsTrue()
    {
        //Arange
        var user = new User() { IsAdmin=true};
        var reserv = new Reservation() { MadeBy=new User() };
        //Act
        bool canBeCancelled = reserv.CanBeCancelledBy(user);
        //Assert
        Assert.That(canBeCancelled, Is.True);
    }
    [Test]
    public void Can_Be_Cancelled_ByMaker_IsTrue()
    {
        //Arange
        var user = new User() { IsAdmin = false };
        var reserv = new Reservation() { MadeBy = user };
        //Act
        bool canBeCancelled = reserv.CanBeCancelledBy(user);
        //Assert
        Assert.That(canBeCancelled, Is.True);
    }
    [Test]
    public void Can_Be_Cancelled_ByOthersNotAdmind_IsFalse()
    {
        //Arange
        var user = new User() { IsAdmin = false };
        var reserv = new Reservation() { MadeBy = new User() };
        //Act
        bool canBeCancelled = reserv.CanBeCancelledBy(user);
        //Assert
        Assert.That(canBeCancelled, Is.False);
    }
}
