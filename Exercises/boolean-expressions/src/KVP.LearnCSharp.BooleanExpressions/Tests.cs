using Xunit;

namespace KVP.LearnCSharp.BooleanExpressions;

public class Tests
{
    /**
     * Den skræmmende rutsjebane HellCoaster™ er vild, og har strenge krav for, om man må
     * tage en tur.
     *
     * - Du skal være mindst 10 år eller i selskab med en voksen.
     * - Selv hvis du er i selskab med en voksen, må du ikke prøve, hvis du er under 8 år.
     * - Alle, der prøver, skal være minimum 100 cm høje.
     * - Du må ikke være synligt beruset.
     *
     * ØVELSE: Implementér 'CanEnterHellCoaster' i Expressions-klassen.
     * ØVELSE: Kan vi fjerne parametre fra funktionen, uden at påvirke dens funktion?
     * VALGFRI ØVELSE: Kan du komprimere udtrykket til én linie uden if eller allokeringer?
     * VALGFRI ØVELSE: Kan du udvide læsbarheden ved at benytte if og flere linier?
     */
    [Fact]
    public void HellCoasterRequirements()
    {
        Assert.False(Expressions.CanEnterHellCoaster("Mark", "with his adult wife, visibly intoxicated", 36, 176, true, false), "Not acceptable because he is intoxicated.");
        Assert.True(Expressions.CanEnterHellCoaster("Thomas", "riding alone", 10, 129, false, true), "Should be accepted, all requirements met.");
        Assert.False(Expressions.CanEnterHellCoaster("Lisa", "riding alone", 6, 112, false, true), "Not acceptable because she is too young.");
        Assert.True(Expressions.CanEnterHellCoaster("Sara", "with her husband", 23, 164, true, true), "Should be accepted, all requirements met.");
        Assert.True(Expressions.CanEnterHellCoaster("William", "with his mother", 9, 129, true, true), "Should be accepted, all requirements met.");
        Assert.False(Expressions.CanEnterHellCoaster("Cecilia", "riding alone", 9, 101, false, true), "Not acceptable because her age requires adult supervision.");
        Assert.False(Expressions.CanEnterHellCoaster("Robert", "riding with his father", 9, 99, true, true), "Not acceptable because he is not tall enough.");
    }
}