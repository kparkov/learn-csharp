using System;

namespace KVP.LearnCSharp.Numbers;

public static class Calculations
{
    /// <summary>
    /// This method takes a value on the kelvin temperature scale,
    /// and returns the celsius equivalent.
    /// </summary>
    /// <param name="kelvin">Degrees in kelvin</param>
    /// <returns>Degrees in celsius</returns>
    public static double KelvinToCelsius(double kelvin)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method takes a value on the celsius temperature scale,
    /// and returns the fahrenheit equivalent.
    /// </summary>
    /// <param name="celsius">Degrees in celsius</param>
    /// <returns>Degrees in fahrenheit</returns>
    public static double CelsiusToFahrenheit(double celsius)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// This method takes a base price, adds danish VAT (25%) and returns
    /// the total price.
    /// </summary>
    /// <param name="basePrice">The price before VAT</param>
    /// <returns>The total price</returns>
    public static decimal WithDanishVAT(decimal basePrice)
    {
        throw new NotImplementedException();
    }


    /// <summary>
    /// Given the radius of a circle, returns the area.
    /// </summary>
    /// <param name="radius">The radius of the circle</param>
    /// <returns>The area of the circle</returns>
    public static double CircleArea(double radius)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Given the mass of two celestial bodies in kg, and their distance
    /// in m, return the gravitational force enacted on both.
    /// </summary>
    /// <param name="body1kg">The mass of body 1</param>
    /// <param name="body2kg">The mass of body 2</param>
    /// <param name="distanceMeters">The distance in meters</param>
    /// <returns>The force in N (newton)</returns>
    public static double GravitationalForce(double body1kg, double body2kg, double distanceMeters)
    {
        const double GravitationalConstant = 6.67408e-11;

        throw new NotImplementedException();
    }
}
