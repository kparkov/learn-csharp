using System;
using Xunit;

namespace KVP.LearnCSharp.Numbers;

public class Tests
{
    // ØVELSE 1: Få Calculator.Add til at opfylde forventningerne.
    [Fact]
    public void CalculatorCanAdd()
    {
        Assert.Equal(expected: 7, actual: Calculator.Add(x: 3, y: 4));
        Assert.Equal(expected: 11, actual: Calculator.Add(x: 2, y: 9));
        Assert.Equal(expected: 2, actual: Calculator.Add(x: 1, y: 1));
        Assert.Equal(expected: 0, actual: Calculator.Add(x: 0, y: 0));
        Assert.Equal(expected: 0, actual: Calculator.Add(x: -5, y: 5));
    }
    
    // ØVELSE 2: Få Calculator.Subtract til at opfylde forventningerne.
    [Fact]
    public void CalculatorCanSubtract()
    {
        Assert.Equal(expected: 22, actual: Calculator.Subtract(x: 29, y: 7));
        Assert.Equal(expected: -663, actual: Calculator.Subtract(x: 213, y: 876));
        Assert.Equal(expected: 3, actual: Calculator.Subtract(x: 15, y: 12));
        Assert.Equal(expected: -2, actual: Calculator.Subtract(x: -12, y: -10));
        Assert.Equal(expected: -10, actual: Calculator.Subtract(x: -5, y: 5));
    }
    
    [Fact]
    // ØVELSE 3: Få Calculator.Multiply til at opfylde forventningerne.
    public void CalculatorCanMultiply()
    {
        Assert.Equal(expected: 16, actual: Calculator.Multiply(x: 4, y: 4));
        Assert.Equal(expected: -16, actual: Calculator.Multiply(x: -4, y: 4));
        Assert.Equal(expected: 12, actual: Calculator.Multiply(x: 4, y: 3));
        Assert.Equal(expected: 2475, actual: Calculator.Multiply(x: 55, y: 45));
        Assert.Equal(expected: 1, actual: Calculator.Multiply(x: 1, y: 1));
        Assert.Equal(expected: 0, actual: Calculator.Multiply(x: 0, y: 5));
    }
    
    // ØVELSE 4: Få Calculate.Divide til at opfylde forventningerne.
    [Fact]
    public void CalculatorCanDivide()
    {
        // 💡 Når et decimaltal forventes, kan vi begrænse sammenligningen
        // til et påkrævet antal decimaler. Der vil så automatisk ske matematisk afrunding.
        Assert.Equal(expected: 2.6667, actual: Calculator.Divide(x: 8, y: 3), precision: 4);
        Assert.Equal(expected: 3, actual: Calculator.Divide(x: 9, y: 3));
        Assert.Equal(expected: 0.4242, actual: Calculator.Divide(x: 14, y: 33), precision: 4);
        Assert.Equal(expected: -2, actual: Calculator.Divide(x: -28, y: 14));
    }
}