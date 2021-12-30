using Xunit;

namespace KVP.LearnCSharp.Tests;

public class Tests
{
    /// <summary>
    /// Vi antager, at to er lig to. Dette er en triviel sandhed og test,
    /// og vi bruger den kun for at demonstrere hvordan tests virker.
    /// </summary>
    /// 
    /// ØVELSE 1: Kør testen og bekræft, at den består.
    [Fact]
    public void TwoShouldEqualTwo()
    {
        // Her er antagelsen:
        Assert.Equal(expected: 2, actual: 2);
    }

    /// <summary>
    /// Vi antager, at to plus to er fire.
    /// </summary>
    ///
    /// ØVELSE 2: denne test fejler. Kør den, og se på test-outputtet for at læse fejlbeskrivelsen. 
    /// ØVELSE 3: giver fejlbeskrivelsen mening? Kan du forklare problemet?
    /// ØVELSE 4: ret fejlantagelsen, så testen består.
    [Fact]
    public void TwoPlusTwoEqualsFour()
    {
        int expected = 5;
        int sum = 2 + 2;

        Assert.Equal(expected: expected, actual: sum);
    }

    /// <summary>
    /// Vi antager, at GetFullName returnerer dit fulde navn.
    /// </summary>
    ///
    /// ØVELSE 5: Her tester vi kode, der ligger i sin egen klasse og fil, 'Names'. Koden
    /// skal returnere dit fulde navn. Ret koden i den anden fil, så antagelserne
    /// bliver sande.
    [Fact]
    public void GetFullNameReturnsMultipleWords()
    {
        string name = Names.GetFullName();
        
        Assert.NotNull(name);
        Assert.NotEmpty(name);

        int numberOfWords = name.Split(separator: " ").Length;
        
        Assert.True(condition: numberOfWords > 1, userMessage: "Et fuldt navn bør indeholde mere end ét ord.");
    }
}