## Editor og projektstruktur

- Visual Studio: de dele, vi skal bruge nu og her (editor og solution explorer).
- Udsagn: koden udgøres af en række udsagn (statement), der afsluttes med semikolon eller starter en blok (se nedenfor). C# er ikke _whitespace sensitive_, så indryk mv har ingen betydning for korrektheden.
```csharp
<udsagn>;

<udsagn> 
{

}
```

- Strukturen i filerne: `Namespace -> Class -> Method -> Logic`
```csharp
using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            // Her skriver vi den egentlige logik.
        }
    }
}
```

- `static void Main(string[] args)`: stedet, hvor et program starter.
- Kodeblok: Et sæt af tuborgklammer `{...}` definerer et _scope_ eller en _kodeblok_ - en markering af, hvor meget den førkommende instruktion omfatter, og samtidig et privat rum for variabler.

```csharp
static void Main(string[] args) 
{
    // Main starter ved den ovenstående tuborgklamme.
    // Alt hvad der sker her, er kun synligt for Main.
    // Men Main kan se og anvende alt, hvad der sker i niveauet ovenover.
    // Main slutter ved den følgende tuborgklamme.
}
```

- Execution flow: Vi kører fra toppen og ned, indtil vi støder på et punkt, der flytter os til en underordnet del af koden. Så kører denne færdig, hvorefter vi vender tilbage til det sted vi slap. Når vi er ved bunden af `Main`, stopper programmet.
- Meget kort C# som et _stærkt og statisk typet, klassisk, imperativt, objekt-orienteret programmeringssprog_.