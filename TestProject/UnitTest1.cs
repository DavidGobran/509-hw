using AutoFixture;
using FluentAssertions;
using Moq;

namespace TestProject;

/// <summary>
/// Represents unit tests for the Calculator and other components.
/// </summary>
public class UnitTest1
{
    private readonly Calculator calculator;

    /// <summary>
    /// Initializes a new instance of the UnitTest1 class.
    /// </summary>
    public UnitTest1()
    {
        this.calculator = new Calculator();
    }

    /// <summary>
    /// Tests the Add method of the Calculator class with inputs 3 and 4.
    /// </summary>
    [Fact]
    public void Add_ThreeAndFour_ShouldReturnSeven()
    {
        // Arrange
        int a = 3, b = 4;

        // Act
        int result = this.calculator.Add(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    /// <summary>
    /// Tests the F method to ensure it returns the first input parameter.
    /// </summary>
    [Fact]
    public void F_should_just_return_first_input_parameter()
    {
        // Arrange
        Fixture fixture = new Fixture();
        int expectedNumber = fixture.Create<int>();
        var a = new Mock<IOne>();
        a.Setup(x => x.ComplexFunction(It.IsAny<int>())).Returns(expectedNumber);

        // Act
        var b = Two.F(expectedNumber, a.Object);

        // Assert
        b.Should().Be(expectedNumber);
    }
}
