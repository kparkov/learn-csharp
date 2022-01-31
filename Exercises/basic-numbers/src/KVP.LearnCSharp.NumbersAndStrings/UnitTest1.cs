using Xunit;

namespace KVP.LearnCSharp.NumbersAndStrings;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        double fahrenheit = 50;
        double celsius = (fahrenheit - 32) * (5d / 9d);
        Assert.Equal("10", celsius.ToString());
    }
}