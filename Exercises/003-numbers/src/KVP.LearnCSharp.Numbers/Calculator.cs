using System;

namespace KVP.LearnCSharp.Numbers;

public static class Calculator
{
    /// <summary>
    /// Returnerer summen af to heltal.
    /// </summary>
    /// <param name="x">Første heltal</param>
    /// <param name="y">Andet heltal</param>
    /// <returns>Summen af de to heltal</returns>
    public static int Add(int x, int y)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Trækker et heltal fra et andet, og returnerer resultatet.
    /// </summary>
    /// <param name="x">Første heltal</param>
    /// <param name="y">Andet heltal</param>
    /// <returns>Resultatet af første heltal fratrukket andet heltal</returns>
    public static int Subtract(int x, int y)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returnerer produktet af to heltal.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public static int Multiply(int x, int y)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Returnerer ratioen imellem første og andet heltal.
    /// </summary>
    /// <param name="x">Første heltal</param>
    /// <param name="y">Andet heltal</param>
    /// <returns>Et decimaltal</returns>
    public static double Divide(int x, int y)
    {
        // BEMÆRK: Når vi dividerer to heltal, vil resultatet ofte være et decimaltal. Hvis vi
        // dividerer to heltal i C#, så vil returværdien også være et heltal, med det tab af
        // præcision, som dette indebærer. For at returnerer et decimaltal, skal ét eller begge
        // tal først konverteres til den ønskede type, her 'double':

        double xAsDouble = (double) x;
        double yAsDouble = (double) y;

        return xAsDouble / yAsDouble;
    }
}