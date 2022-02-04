using Xunit;

namespace KVP.LearnCSharp.BooleanExpressions;

public class Tests
{
    /**
     * Man kan få lov til at læse et semester i udlandet, hvis man har bestået sin
     * bacheloreksamen, og har et snit på mindst 7. Alternativt kan man få en §8 dispensation,
     * der dispenserer fra begge krav.
     *
     * ØVELSE: Implementér CanStudyAbroad i Expressions-klassen, så de følgende tests består.
     * ØVELSE: Kan du reducere løsningen, så den er ét samlet udtryk, én linie og ingen
     *         variabel-erklæringer?
     */
    [Fact]
    public void CanStudyAbroad()
    {
        Assert.True(Expressions.CanStudyAbroad(hasBaDiploma: true, average: 9.5m, hasDispensation: true), "SHOULD PASS: All requirements are met.");
        Assert.True(Expressions.CanStudyAbroad(hasBaDiploma: true, average: 7.1m, hasDispensation: false), "SHOULD PASS: Ordinary requirements met, no need for dispensation.");
        Assert.True(Expressions.CanStudyAbroad(hasBaDiploma: true, average: 4.5m, hasDispensation: true), "SHOULD PASS: Average is too low, but has a dispensation.");
        Assert.True(Expressions.CanStudyAbroad(hasBaDiploma: false, average: 7.9m, hasDispensation: true), "SHOULD PASS: No degree, but has a dispensation.");
        Assert.True(Expressions.CanStudyAbroad(hasBaDiploma: false, average: 2.1m, hasDispensation: true), "SHOULD PASS: No degree and low average, but still has a dispensation.");
        Assert.False(Expressions.CanStudyAbroad(hasBaDiploma: false, average: 11.1m, hasDispensation: false), "SHOULD FAIL: No degree and no dispensation.");
        Assert.False(Expressions.CanStudyAbroad(hasBaDiploma: true, average: 6.5m, hasDispensation: false), "SHOULD FAIL: Average too low with no dispensation.");
        Assert.False(Expressions.CanStudyAbroad(hasBaDiploma: false, average: 3.3m, hasDispensation: false), "SHOULD FAIL: No degree and low average without dispensation.");
    }
    
    /**
     * Baren sælger drinks til alle, der har penge nok til den billigste genstand, hvis bare man er
     * voksen og ikke er fuld i forvejen. Hvis man er berømt, så er der til gengæld ingen begrænsninger
     * - så siger baren aldrig nej.
     *
     * ØVELSE: Implementér WillTheBarServe i Expressions-klassen.
     */
    [Fact]
    public void WillTheBarServe()
    {
        Assert.True(Expressions.WillTheBarServe(money: 55m, minimumDrinkPrice: 45m, age: 45, intoxicated: false, famous: false), "SHOULD PASS: All requirements are met.");
        Assert.False(Expressions.WillTheBarServe(money: 75m, minimumDrinkPrice: 20m, age: 88, intoxicated: true, famous: false), "SHOULD FAIL: The person is intoxicated.");
        Assert.False(Expressions.WillTheBarServe(money: 150m, minimumDrinkPrice: 110m, age: 8, intoxicated: false, famous: false), "SHOULD FAIL: The person is under age.");
        Assert.False(Expressions.WillTheBarServe(money: 150m, minimumDrinkPrice: 110m, age: 24, intoxicated: false, famous: false), "SHOULD FAIL: The person is under age.");
    }

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
    
    /**
     * Busprissystemet er blevet meget kompliceret. Derfor har man brug for at automatisere det. Her er
     * regelsystemet for, hvordan man udregner prisen for en tur:
     *
     * - Det koster 10 kroner pr zone man kører i på busrejsen, dog maksimalt 10 zoner.
     * - Børn under 7 år kører gratis.
     * - Børn under 15 år betaler halv pris for hele rejsen.
     * - Gangbesværede kører gratis de første 5 zoner, men betaler efter alder for resten.
     * - Studerende får 40% rabat på de første 5 zoner, men betaler efter alder for resten.
     * - Pensionister får 80% rabat på hele rejsen og ikke andet, uanset alle andre gældende forhold.
     * - Hvis man falder i gensidigt udelukkende kategorier, nyder man den mest fordelagtige rabat.  
     *
     * ØVELSE: Implementér GetBusPrice i Expressions-klassen.
     * HINT: Benyt if / else if / else, og brug return så snart du kan lukke et scenarie.
     */
    [Fact]
    public void GetBusPrice()
    {
        // Voksen uden særlige forhold skal betale 30 kr for 3 zoner.
        Assert.Equal(30m, Expressions.GetBusPrice(3, 47, false, false, false));
        
        // 14-årig uden andre forhold skal betale 20 kr for 4 zoner.
        Assert.Equal(20m, Expressions.GetBusPrice(4, 14, false, false, false));
        
        // Børn under 7 kører gratis, uanset andre forhold.
        Assert.Equal(0m, Expressions.GetBusPrice(8, 5, true, false, false));
        
        // En gangbesværet voksen betaler 20 kr. for 7 zoner.
        Assert.Equal(20m, Expressions.GetBusPrice(distanceZones: 7, age: 55, walkingDisability: true, student: false, pensioner: false));
        
        // En gangbesværet voksen betaler 0 kr. for 3 zoner.
        Assert.Equal(0m, Expressions.GetBusPrice(distanceZones: 3, age: 45, walkingDisability: true, student: false, pensioner: false));
        
        // En studerende betaler 50 kr. for 7 zoner.
        Assert.Equal(50m, Expressions.GetBusPrice(distanceZones: 7, age: 24, walkingDisability: false, student: true, pensioner: false));
        
        // En studerende betaler 18 kr. for 3 zoner.
        Assert.Equal(18m, Expressions.GetBusPrice(distanceZones: 3, age: 66, walkingDisability: false, student: true, pensioner: false));
        
        // En gangbesværet studerende får den bedste rabat og betaler 20 kr. for 7 zoner. 
        Assert.Equal(20m, Expressions.GetBusPrice(distanceZones: 7, age: 18, walkingDisability: true, student: true, pensioner: false));
        
        // En gangbesværet 13-årig betaler 10 kr. for 7 zoner.
        Assert.Equal(10m, Expressions.GetBusPrice(distanceZones: 7, age: 13, walkingDisability: true, student: false, pensioner: false));
        
        // En pensionist betaler 20 kr for 10 zoner.
        Assert.Equal(20m, Expressions.GetBusPrice(distanceZones: 10, age: 82, walkingDisability: false, student: false, pensioner: true));
        
        // En gangbesværet 13-årig pensionist betaler 10 kr for 5 zoner.
        Assert.Equal(10m, Expressions.GetBusPrice(distanceZones: 5, age: 13, walkingDisability: true, student: false, pensioner: true));
    }
}