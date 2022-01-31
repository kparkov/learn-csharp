using Xunit;

namespace KVP.LearnCSharp.Numbers;

public class Tests
{
    /**
     * ØVELSE 1: Implementér KelvinToCelsius-omregneren korrekt i "Calculations"-klassen.
     *           Brug en søgemaskine til at finde den korrekte formel.
     */
    [Fact]
    public void Exercise_01_CanConvertKelvinToCelsius()
    {
        Assert.Equal(-40.00, Calculations.KelvinToCelsius(233.15), precision: 2);
        Assert.Equal(21.00, Calculations.KelvinToCelsius(294.15), precision: 2);
        Assert.Equal(100.00, Calculations.KelvinToCelsius(373.15), precision: 2);
        Assert.Equal(962.61, Calculations.KelvinToCelsius(1235.76321), precision: 2);
    }

    /**
     * ØVELSE 2: Implementér CelsiusToFahrenheit-omregneren korrekt.
     */
    [Fact]
    public void Exercise_02_CanConvertCelsiusToFahrenheit()
    {
        Assert.Equal(-22.00, Calculations.CelsiusToFahrenheit(-30), precision: 2);
        Assert.Equal(14.00, Calculations.CelsiusToFahrenheit(-10), precision: 2);
        Assert.Equal(50.00, Calculations.CelsiusToFahrenheit(10), precision: 2);
        Assert.Equal(122.00, Calculations.CelsiusToFahrenheit(50), precision: 2);
        Assert.Equal(125.60, Calculations.CelsiusToFahrenheit(52), precision: 2);
    }

    /**
     * ØVELSE 3: Implementér WithDanishVAT. Den danske moms er 25% af prisen.
     */
    [Fact]
    public void Exercise_03_CanCalculatePriceWithVATAdded()
    {
        Assert.Equal(25.00m, Calculations.WithDanishVAT(20.00m), precision: 2);
        Assert.Equal(46.25m, Calculations.WithDanishVAT(37.00m), precision: 2);
        Assert.Equal(194.38m, Calculations.WithDanishVAT(155.50m), precision: 2);
        Assert.Equal(1601.56m, Calculations.WithDanishVAT(1281.25m), precision: 2);
        Assert.Equal(12499.99m, Calculations.WithDanishVAT(9999.99m), precision: 2);
    }

    /**
     * ØVELSE 4: Implementér CircleArea, som returnerer arealet for en cirkel.
     */
    [Fact]
    public void Exercise_04_CanCalculateCircleArea()
    {
        Assert.Equal(3.141593, Calculations.CircleArea(1), precision: 6);
        Assert.Equal(7.068583, Calculations.CircleArea(1.5), precision: 6);
        Assert.Equal(78.539816, Calculations.CircleArea(5.0), precision: 6);
        Assert.Equal(510.945516, Calculations.CircleArea(12.753), precision: 6);
        Assert.Equal(4016.274959, Calculations.CircleArea(35.755), precision: 6);
    }

    /**
     * ØVELSE 5: Implementér GravitationalForce, som returnerer den gensidige
     *           gravitation, som to himmellegemer udøver på hinanden.
     */
    [Fact]
    public void Exercise_05_CanCalculateGravitationalForce()
    {
        double earthMass = 5.972e24;
        double moonMass = 7.3477e22;
        double earthMoonDistance = 3.844e8;
        double earthMoonForce = 19.819644724020357e19;

        Assert.Equal(earthMoonForce, Calculations.GravitationalForce(earthMass, moonMass, earthMoonDistance), precision: 2);
        Assert.Equal(16.6852, Calculations.GravitationalForce(5e6, 5e6, 10), precision: 4);
        Assert.Equal(1.1212, Calculations.GravitationalForce(12e6, 14e6, 100), precision: 4);
        Assert.Equal(600667.2, Calculations.GravitationalForce(18e8, 5e8, 10), precision: 4);
        Assert.Equal(3971.3534, Calculations.GravitationalForce(6e19, 12e17, 11e11), precision: 4);
    }
}