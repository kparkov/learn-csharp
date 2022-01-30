using System;
using System.Linq;
using System.Reflection;
using Xunit;

namespace KVP.LearnCSharp.BasicFunctions;

public class Tests
{
    /**
     * ØVELSE 1: Denne test består, når den eksisterende klasse "Calculator" har en metode med navnet "Sum".
     */
    [Fact]
    public void Exercise_01_CalculatorHasMethodSum()
    {
        Assert.True(typeof(Calculator).GetMethod("Sum") is not null, $"{nameof(Calculator)} has no method 'Sum'.");
    }

    /**
     * ØVELSE 2: Denne test består, når metoden "Sum" er public og static.
     */
    [Fact]
    public void Exercise_02_SumMethodIsPublicAndStatic()
    {
        MethodInfo method = typeof(Calculator)?.GetMethod("Sum");

        Assert.NotNull(method);
        Assert.True(method.IsPublic, "The method Sum is not public.");
        Assert.True(method.IsStatic, "The method Sum is not static.");
    }

    /**
     * ØVELSE 3: Denne test består, når "Sum" returnerer 'double' ifølge sin signatur.
     */
    [Fact]
    public void Exercise_03_SumReturnsDouble()
    {
        Type returnType = typeof(Calculator)?.GetMethod("Sum")?.ReturnType;
        Assert.True(returnType == typeof(double), $"Expected return type to be double, but it was {returnType?.Name ?? "absent"}.");
    }

    /**
     * ØVELSE 4: Denne test består, når "Sum" tager to parametre.
     */
    [Fact]
    public void Exercise_04_SumTakesTwoParameters()
    {
        var parameters = typeof(Calculator)?.GetMethod("Sum")?.GetParameters();
        
        Assert.NotNull(parameters);
        Assert.NotEmpty(parameters);
        Assert.Equal(2, parameters.Length);
    }

    /**
     * ØVELSE 5: Denne test består, når alle parametre er af typen 'double'.
     */
    [Fact]
    public void Exercise_05_AllParametersAreOfTypeDouble()
    {
        var parameters = typeof(Calculator).GetMethod("Sum")?.GetParameters();

        var isAllDouble = parameters
            .All(x => x.ParameterType == typeof(double));

        Assert.True(parameters.Length > 0, "Sum has no parameters.");
        Assert.True(isAllDouble, "Not all parameters are of type 'double', or there are no parameters.");
    }

    /**
     * ØVELSE 6: Denne test består, når 'Sum' returnerer summen af de to parametre, der sendes med.
     */
    [Theory]
    [InlineData(3.3, 6.8, 10.1)]
    [InlineData(1.33, 2.75, 4.08)]
    [InlineData(4.23, 5.6732, 9.9032)]
    public void Exercise_06_SumReturnsTheSumOfTwoDoubles(double x, double y, double expected)
    {
        var method = typeof(Calculator).GetMethod("Sum");
        var value = method.Invoke(null, new object[] { x, y });

        Assert.Equal(expected, value);
    }

    /**
     * ØVELSE 7: Denne test består, når der eksisterer en metode "Divide" i "Calculator",
     *           der tager to doubles, dividerer dem og returnerer resultatet.
     *
     *           Bemærk, at vi er ligeglade med, om metoden virker efter hensigten.
     *           Vi er kun interesseret i metodesignaturen.
     */
    [Fact]
    public void Exercise_07_ExpectADivideMethod()
    {
        UnitTesting.AssertShape(new("Divide", typeof(double), 2, new Type[] { typeof(double), typeof(double) }));
    }

    /**
     * ØVELSE 8: Denne test består, når der eksisterer en metode "GetFullName",
     *           der tager tre dele af et navn, og returnerer det fulde navn som
     *           en enkelt streng.
     *
     *           Bemærk, at vi er ligeglade med, om metoden virker efter hensigten.
     *           Vi er kun interesseret i metodesignaturen.
     */
    [Fact]
    public void Exercise_08_ExpectGetFullNameMethod()
    {
        UnitTesting.AssertShape(new("GetFullName", typeof(string), 3, new Type[] { typeof(string), typeof(string), typeof(string) }));
    }

    /**
     * ØVELSE 9: Denne test består, når der eksisterer en metode "CountNameLength",
     *           der tager tre dele af et navn, og returnerer den fulde længde af navnet.
     *
     *           Bemærk, at vi er ligeglade med, om metoden virker efter hensigten.
     *           Vi er kun interesseret i metodesignaturen.
     */
    [Fact]
    public void Exercise_09_ExpectACountNameLengthMethod()
    {
        UnitTesting.AssertShape(new("CountNameLength", typeof(int), 3, new Type[] { typeof(string), typeof(string), typeof(string) }));
    }

    /**
     * ØVELSE 10: Denne test består, når der eksisterer en metode "RepeatString",
     *            der tager en string og et antal gange, som den skal gentages - og returnerer den resulterende tekst.
     *
     *            Bemærk, at vi er ligeglade med, om metoden virker efter hensigten.
     *            Vi er kun interesseret i metodesignaturen.
     */
    [Fact]
    public void Exercise_10_ExpectARepeatStringMethod()
    {
        UnitTesting.AssertShape(new("RepeatString", typeof(string), 2, new Type[] { typeof(string), typeof(int) }));
    }


}