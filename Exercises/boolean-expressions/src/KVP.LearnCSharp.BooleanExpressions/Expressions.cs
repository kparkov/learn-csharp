using System;

namespace KVP.LearnCSharp.BooleanExpressions;

public static class Expressions
{
    public static bool CanStudyAbroad(bool hasBaDiploma, decimal average, bool hasDispensation)
    {
        throw new NotImplementedException();
    }
    
    public static bool WillTheBarServe(decimal money, decimal minimumDrinkPrice, int age, bool intoxicated, bool famous)
    {
        return famous || (!intoxicated && age >= 18 && money >= minimumDrinkPrice);
    }

    public static decimal GetBusPrice(int distanceZones, int age, bool walkingDisability, bool student, bool pensioner)
    {
        throw new NotImplementedException();
    }
    
    /// <summary>
    /// Takes a range of guest parameters, and returns whether access is granted to the
    /// HellCoaster™ ride.
    /// </summary>
    /// <param name="name">The name of the guest</param>
    /// <param name="description">A description of the guest</param>
    /// <param name="age">The age of the guest</param>
    /// <param name="height">The height in cm of the guest</param>
    /// <param name="adultSupervision">Whether the guest is accompanied by an adult</param>
    /// <param name="sober">Whether the guest appears sober</param>
    /// <returns>true for access granted, false if forbidden</returns>
    public static bool CanEnterHellCoaster(string name, string description, int age, int height, bool adultSupervision, bool sober)
    {
        throw new NotImplementedException();
    }
}