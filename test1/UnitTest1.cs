namespace test1;
using calc;

public class UnitTest1
{
    [Fact]
    public void Add_Should_Work()
    {
        var calc = new Calc();
        var result = calc.Add(1, 2);
        Assert.Equal(3, result);
    }

    [Fact]
    public void Sub_Should_Work()
    {
        var calc = new Calc();
        var result = calc.Sub(1, 2);
        Assert.Equal(-1, result);
    }
}