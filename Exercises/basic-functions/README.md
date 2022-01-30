## Introduktion til funktioner

En funktion (function) er et afgrænset stykke programkode, der, når det _kaldes_ fra anden kode, bliver kørt / evalueret fra toppen, og kører indtil funktionen _returnerer_ eller naturligt terminerer (når til slutningen). Herefter fortsætter programmet derfra, hvor funktionen blev kaldt, eventuelt med et overført resultat fra funktionen. En funktion kan kaldes flere eller mange gange.

En funktion kan have et eller flere inputs, kaldet _argumenter_ (arguments) eller _parametre_ (parameters), og det kan have et output (og kun ét), kaldet en _returværdi_ (return value), som kan bruges af den _kaldende kode_ (den kodekontekst, som eksekverede funktionen) i den videre kørsel.

En funktion, der er defineret som medlem af en _klasse_ (class), kaldes en _metode_ (method), og da stort set al kode i C# er underordnet klasser, beskæftiger vi os i første omgang med funktioner, der er metoder. 

Vi behøver ikke at vide så meget om klasser endnu. De bør i første omgang anses som en måde at gruppere kode efter funktionalitet. Senere vil vi udvide denne forståelse betragteligt.

### Metodesignaturen

Metoder har en metodesignatur, som fortæller den kaldende kode, hvad der skal ind i funktionen, og hvad der kommer ud. Vi er allerede stødt på én metode:

```csharp
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Test");
    }
}
```

Metodesignaturen er udsagnet før metodens kodeblok, dvs:

```csharp
public static void Main(string[] args)
```

Første del, `public`, betyder grundlæggende, at metoden kan kaldes fra alle steder i koden, og `static` at vi ikke behøver en _objektinstans af klassen_ (noget vi først vil høre mere om senere). 

Herefter kommer _returtypen_ `void`, dvs hvilken type metoden returnerer. `void` betyder faktisk, at den _ikke_ returnerer en værdi. Man kan angive en hvilken som helst type, fx `string` / `int` / `bool`, men det forpligter så til, at funktionen i alle tilfælde returnerer en værdi af den angivne type med keyword `return`.

Herefter følger navnet, "Main". "Main" er et eksempel på en metode, som vi ikke selv kan vælge navnet på, men generelt set kan vi selv vælge, hvad en metode skal hedde.

I parentesen følger metodens argumenter som type- og navngivne variabler, i dette tilfælde `string[] args`, dvs _et array af strings, som vi i denne kontekst kalder "args"_ (mere om arrays senere).

### Eksempel

En metode, der tager et tal og returnerer tallet plus et, ser sådan ud:

```csharp
public static int AddOne(int x)
{
    return x + 1;
}
```

Metoden kan anvendes sådan:

```csharp
public class Program 
{
    public static int AddOne(int x)
    {
        return x + 1;
    }

    public static void Main(string[] args) 
    {
        int number = 17;
        int incrementedNumber = AddOne(number);

        System.Console.WriteLine(incrementedNumber);
    }
}
```

Dette program udskriver:

```
18
```

Bemærk, at tallet hedder `number` i den kaldende kontekst (`Main`), men når funktionen har modtaget værdien, kaldes det samme tal `x`. Dette er en konsekvens af, at både `number` og `x` er variabler, der kun eksisterer i det lokale scope, dvs den omgivende kodeblok. Værdien bringes videre, men under et nyt navn.

Bemærk desuden, at eftersom `AddOne` lover en returværdi af typen `int`, så skal der følge et udtryk af typen `int` efter `return`.

Her er et andet eksempel, hvor den kaldte metode ligger i en anden klasse. Bemærk, at så skal klassen indgå i kaldet fra den kaldende kode.

```csharp
public class Calculator
{
    public static int AddOne(int x)
    {
        return x + 1;
    }
}

public class Program 
{
    public static void Main(string[] args) 
    {
        int number = 17;
        int incrementedNumber = Calculator.AddOne(number);

        System.Console.WriteLine(incrementedNumber);
    }
}
```

### Programstruktur

Den første metode, der kaldes, er `Main`. Her starter og slutter programmet. Undervejs kalder vi metoder, som eventuelt kalder nye metoder. Hver gang vi kalder en ny metode, lægger vi et nyt lag af lokal hukommelse ovenpå i det, som kaldes _kaldstakken_ (call stack). Hver gang en metode returnerer, fjerner vi det øverste lag igen.

Programkørslen kan visualiseres således:

<visualisering af kaldstakken>

### Øvelser

