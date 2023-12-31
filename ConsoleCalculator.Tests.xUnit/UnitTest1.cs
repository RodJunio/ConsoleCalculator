namespace ConsoleCalculator.Tests.xUnit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var sut = new Calculator();

        Assert.Throws<CalculationOperationNotSupportedException>(
            () => sut.Calculate(1, 1, "+"));

        Assert.ThrowsAny<CalculationException>(() => sut.Calculate(1, 1, "+"));
    }
}