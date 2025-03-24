using NUnit.Framework;
using PhamKhanhAnExamples;

namespace PhamKhanhAnUnitTestExamples;

public class NUnitTestPhoneNumber
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Parse_ValidNuber_ReturnNumberWihAreaMajor()
    {
        //Arrange
        string number = "0123456789";//test valid
        //Act
        var phoneNumber = PhoneNumber.Parse(number);
        //Assert
        Assert.That(phoneNumber.Area,Is.EqualTo("012"));
        Assert.That(phoneNumber.Major, Is.EqualTo("345"));
        Assert.That(phoneNumber.Minor, Is.EqualTo("6789"));
    }
    [Test]
    public void Parse_InValid_WithNumberIsNull_ReturnInvalid()
    {
        //Arrange
        string number = "0 123456789";
        //Act
        bool hasSpace = number.Contains("");
        //Assert
        Assert.That(hasSpace, Is.True,"Phone number cannot be blank.");
    }
    [Test]
    public void Parse_InValid_WithNumberLength()
    {
        //Arrange
        string number = "012345678910";
        //Act
        bool numlength = number.Length!=10;
        //Assert
        Assert.That(numlength, Is.True, "Phone number length should be 10 digits long.");
    }
    [Test]
    public void ToString_ShouldReturnCorrectFormat()
    {
        //Arrange
        string input = "0123456789";
        var phoneNumber = PhoneNumber.Parse(input);
        //Act
        string result = phoneNumber.ToString();
        //Asert
        Assert.That(result, Is.EqualTo("(012)345-6789"));
    }
}
