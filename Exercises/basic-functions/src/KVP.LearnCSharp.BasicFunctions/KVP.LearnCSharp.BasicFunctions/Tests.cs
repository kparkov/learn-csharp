using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace KVP.LearnCSharp.BasicFunctions;

public class Calculator
{
    public void Sum()
    {
        
    }
}

public class Tests
{
    /**
     * ØVELSE 1: Denne test består, når klassen "Calculator" har en metode med navnet "Sum". 
     */
    [Fact]
    public void CalculatorHasMethodSum()
    {
        Assert.True(typeof(Calculator).TypeHasMethod("Sum"), $"{nameof(Calculator)} has no method 'Sum'.");
    }

    /**
     * ØVELSE 2: Denne test består, når metoden "Sum" er public og static.
     */
    [Fact]
    public void SumMethodIsPublicAndStatic()
    {
        MethodInfo method = typeof(Calculator)?.GetMethod("Sum");

        Assert.NotNull(method);
        Assert.True(method.IsPublic, "The method Sum is not public.");
        Assert.True(method.IsStatic, "The method Sum is not static.");
    }

    /**
     * ØVELSE 3: Denne test består, når "Sum" returnerer 'double'. 
     */
    [Fact]
    public void SumReturnsDouble()
    {
        Type returnType = typeof(Calculator)?.GetMethod("Sum")?.ReturnType ?? typeof(object);
        Assert.True(returnType == typeof(double));
    }

    /**
     * ØVELSE 4: Denne test består, når "Sum" tager to parametre af typen 'double'.
     */
    public void SumTakesTwoParametersOfTypeDouble()
    {
        var parameters = typeof(Calculator)?.GetMethod("Sum")?.GetParameters();
        
        Assert.NotNull(parameters);
        Assert.NotEmpty(parameters);
    }
    
}

public static class UnitTesting
{
    public static bool TypeHasMethod(this System.Type type, string name)
    {
        return type.GetMethods().Select(n => n.Name).Contains(name);
    }
    
}