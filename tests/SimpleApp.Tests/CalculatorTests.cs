using Xunit;
using SimpleApp;

namespace SimpleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();
    
    [Theory]
    [InlineData(5, 3, 8)]
    [InlineData(-2, 7, 5)]
    [InlineData(0, 0, 0)]
    public void Add_ReturnsCorrectSum(int a, int b, int expected)
    {
        var result = _calculator.Add(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(10, 4, 6)]
    [InlineData(7, 2, 5)]
    public void Subtract_ReturnsCorrectDifference(int a, int b, int expected)
    {
        var result = _calculator.Subtract(a, b);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(7, 6, 42)]
    [InlineData(3, 4, 12)]
    public void Multiply_ReturnsCorrectProduct(int a, int b, int expected)
    {
        var result = _calculator.Multiply(a, b);
        Assert.Equal(expected, result);
    }
    
    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
    
    [Theory]
    [InlineData(4, true)]
    [InlineData(7, false)]
    public void IsEven_ReturnsCorrectResult(int number, bool expected)
    {
        var result = _calculator.IsEven(number);
        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(17, true)]
    [InlineData(4, false)]
    [InlineData(1, false)]
    public void IsPrime_ReturnsCorrectResult(int number, bool expected)
    {
        var result = _calculator.IsPrime(number);
        Assert.Equal(expected, result);
    }
}
