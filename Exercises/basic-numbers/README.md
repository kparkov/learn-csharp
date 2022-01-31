## Introduktion til at anvende tal

Tal er blandt de basale datatyper, som vi bruger hele tiden i programmering. Der er 10 heltalstyper (ja, hele 10 typer kun til tal uden decimaler) og 3 typer til decimaltal. 

Dog benytter vi kun under normale omstændigheder en håndfuld, så lad os holde os til de nødvendige (og klart mest hyppigt forekommende) lige nu:

| Datatype  | Navn                                            | Kategori  | Størrelse          | Beskrivelse                                                                       | 
| --------- | ----------------------------------------------- | --------- | ------------------ | --------------------------------------------------------------------------------- |
| `int`     | Heltal (integer)                                | Værdi     | 32 bits            | Et heltal fra -2.147.483.648 til 2.147.483.647                                    |
| `long`    | Stort heltal (long integer)                     | Værdi     | 64 bits            | Et heltal fra -9.223.372.036.854.775.808 til 9.223.372.036.854.775.807            |
| `float`   | Flydende decimaltal (floating point number)     | Værdi     | 32 bits            | Fysiske og naturlige decimaltal med uendelig decimalrække og aftagende præcision. |
| `double`  | Dobbelt præcisionstal (double precision number) | Værdi     | 64 bits            | Enorme eller meget små naturlige decimaltal.                                      |
| `decimal` | Decimaltal (decimal number)                     | Værdi     | 128 bits           | Kunstige decimaltal med endelig decimalrække og høj præcision.                    |

### Konkrete værdier (literal values)

Når vi skal angive en type indenfor en konkret type, så er der bestemt formater vi anvender. Man kunne måske tro, at erklæringen af typen var nok, men somme tider anvender vi en konkret værdi uden en forudgående, utvetydig erklæring. Når vi f.eks. bruger `var`-formen til at eklære en variabel, ville det ikke være muligt at skelne om det er `int` eller `long` der tilsigtes, hvis tallet ikke overstiger grænsen for `int`. Det gøres med den konkrete form.

```csharp
// int
var myInt = 16;

// long
var myLong = 16L;

// float
var myFloat = 16.7623f;

// double
var myDouble = 16.7623d;

// decimal
var myDecimal = 16.7623m;
```

Dog, hvis et tal har decimaler, men _suffix udelades_, så vil det blive compilet som en `double`:

```csharp
var myDouble = 16.7623;
```

Ligeledes er det tilladt at angive en konkret `int` i initialiseringen af et eksplicit flydende decimaltal.

```csharp
float myFloat = 16;
decimal myDecimal = 16;
double myDouble = 16.7623d;
```

Videnskabelig notation er tilgængelig, både for flydende decimaltal og heltal.

```csharp
float myLargeNumber = 1.9213e6;

// myLargeNumber = 1.9213x10^6
// myLargeNumber = 1921300
```

Vi kan desuden bruge underscore `_` i et tal. Det har ingen betydning, men kan f.eks. anvendes som tusindtalsseparator, for læsbarhedens skyld.

```csharp
int myLargeNumber = 1_921_300;

// myLargeNumber = 1921300
```

### Operatorer på tal

Operatorer er logiske eller matematiske operationer imellem to værdier. Herunder f.eks. `+` (plus), `-` (minus), `/` (division) og `*` (multiplikation). Taltyperne understøtter dem alle.

Her er et eksempel på omregning fra fahrenheit til celsius.

```csharp
double fahrenheit = 50.00;
double celsius = (fahrenheit - 32d) * (5d / 9d);
System.Console.WriteLine(celsius);
```

Dette udskriver:

```
10
```

Man kan godt blande taltyper i et samlet matematisk udtryk, men det er farligt terræn, som man bør kende godt, før man gør det. Eksempelvis er der også en divisionsoperator for `int / int`, men den returnerer også `int`, og fjerner derfor alle decimaler i resultatet. Lad os prøve ovenstående udregning uden eksplicitte typer:

```csharp
double fahrenheit = 50.00;
double celsius = (fahrenheit - 32) * (5 / 9);
System.Console.WriteLine(celsius);
```

Nu udskriver den:

```
0
```

Den første parentes `(fahrenheit - 32)` går fint med blandede typer, fordi `double - int = double`, men i evalueringen af den anden parentes har vi `int / int = int` med det tilhørende tab af præcision, så `(5 / 9) = 0`. Når vi ganger det øvrige udtryk ind, ender det hele som `0`.

Vi kan faktisk redde det hele ved brug af blot én `double` i divisionen, da både `double / int = double` og `int / double = double`, så `(5 / 9d) = .5556`.

Dette er et eksempel på, at man skal være opmærksom på præcedens (mere om præcedens nedenfor) og samspil mellem typer i udtryk.

### Andre operatorer og `Math`

Lidt specielt er det, at der ikke er en indbygget operator til at opløfte et tal i potens i C#. I sådanne tilfælde må man ty til funktionsbiblioteket `System.Math`, der indeholder et stort antal funktioner fra lommeregneren, f.eks.:

```csharp
int Math.Abs(int value)                     // fjerner et eventuelt fortegn, så fx -12 bliver til 12
double Math.Cos(double d)                   // beregner cosinus af d
double Math.Log10(double d)                 // returnerer base 10 logaritmen til d
int Math.Max(int a, int b)                  // returnerer det højeste tal blandt a og b
int Math.Min(int a, int b)                  // returnerer det mindste tal blandt a og b
double Math.Pow(double x, double y)         // løfter x til potens y
double Math.Round(double d, int decimals)   // runder d af til nærmeste antal decimals
double Math.Sqrt(double d)                  // returnerer kvadratroden af d

// ... og mange, mange flere!
```

### Eksempel på brug af taludtryk i funktion

Her bruger vi `+`, `Math.Sqrt` og `Math.Pow` til at lave en implementering af [Pythagoras' læresætning om hypotenusens længde](https://www.webmatematik.dk/lektioner/eud-matematik/tomrer/pythagoras-laeresaetning-og-vinkelberegning):

```csharp
public static double Hypotenuse(double a, double b)
{
    double a2 = Math.Pow(a, 2);
    double b2 = Math.Pow(b, 2);
    double hypotenuseLength = Math.Sqrt(a2 + b2);
    return hypotenuseLength;
}
```

Denne implementering er en _step by step_ allokering af de enkelte elementer i forskellige variabler, der til sidst samles i en resulterende længde på hypotenusen, der så returneres. 

Når der ikke er øvrige kontrolstrukturer involveret, kan vi altid erstatte variablerne med det oprindelige udtryk i stedet, og vi kan dermed implementere en løsning, der ikke allokerer variabler overhovedet:

```csharp
public static double Hypotenuse(double a, double b)
{
    return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
}
```

Kan løsningen skrives på en enkelt, kortfattet linie, der endda spejler matematikkens oplæg så fint, så er det at foretrække. 

Introduktionen af variabel-allokeringer bør være styret af nødvendighed og eventuelt læsevenlighed. Hvis en kodesætning bliver for lang, bliver den meget svær at forstå. 

Man kan på denne måde forstå kodesætninger som rigtige sætninger. Man kan skrive lange, snørklede og omhyggelige sætninger, der er svære at læse og forstå, men komplette og udtømmende. Man kan også skrive korte sætninger. Sætninger, der opbygger en forståelse. Trin for trin. Bid for bid.

Endelig er der korte og koncise sætninger, der er komplette - sjældne, men klart at foretrække!

### Opdatering af variabel

Når man ønsker at opdatere værdien på en variabel, kan man anvende variablens nuværende værdi i udtrykket. Den øjeblikkelige værdi evalueres, indsættes i udtrykket, udtrykket evalueres, og variablen overskrives.

```csharp
int x = 7;
x = x + 1;

// x = x + 1
// x = 7 + 1
// x = 8
```

En kortere form til opdatering af en variabel baseret på den nuværende værdi er denne form:

```csharp
int x = 7;
x += 3;    // svarer til: x = x + 3
// x = 10
```

Denne logik gælder også for andre operatorer.

```csharp
int x = 10;
x = x - 3;

// x = 7

x -= 3;

// x = 4

x *= 5;

// x = 20

x /= 2;

// x = 10

x %= 3

// x = 1
```

Hvis man anvender blandede typer i et udtryk, skal man sikre sig, at den resulterende værdi er af den ønskede type. Dette vil ikke kompilere:

```csharp
int x = 7;
x = x / 10.5;
```

Fejlen er `Cannot implicitly convert 'double' to 'int'`. Da `int / double = double`, kan x ikke efterfølgende modtage værdien, der nu er `double`. Vi vil senere lære måder at håndtere dette problem.

#### Operatorers præcedens

Præcedensen af operatorer er som i matematikken - multiplikation før plus osv. Hvis man bliver i tvivl om præcedens, bør man tilføje parenteser. De er altid tilladt i udtryk. Senere kommer der nye operatorer (fx de boolske operatorer), og på det tidspunkt vil vi genbesøge præcedens.

Se eventuelt [den fulde tabel over operator-præcedens i C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence).

### Modulo operator

En operator, som vi ikke ser meget i almindelig hovedregning, men som er fremtrædende i programmering, er modulo-operatoren `%`. Den returnerer rest efter division.

```csharp
int x = 20;
int y = x % 6;

// y = 2, fordi 6 går 3 gange op i 20 - 3 * 6 = 18, med en rest på 2.
```

Der er mange eksempler, hvor vi bruger modulo. Ønsker vi fx at udskrive en status hver gang vi har udført 200 opgaver, så kan vi benytte modulo på opgave-tælleren.

```cs
// Vi har lavet 0 opgaver.
int tasksDone = 0;

// Vi har mange opgaver tilbage.
int tasksLeft = 1350;

// Gentag denne blok, hvis der stadig er opgaver tilbage.
while (tasksLeft > 0)
{
    // TODO: Skriv koden til at udføre opgaven her...

    // Én opgave mere er udført.
    tasksDone = tasksDone + 1;

    // Én opgave mindre at udføre.
    tasksLeft = tasksLeft - 1;

    // Hvis resten af tasksDone divideret med 200 er lig med 0, så gør følgende...
    if (tasksDone % 200 == 0) 
    {
        System.Console.WriteLine("Har udført " + tasksDone + " opgaver.");
    }
}
```

Dette program udskriver:

```
Har udført 200 opgaver.
Har udført 400 opgaver.
Har udført 600 opgaver.
Har udført 800 opgaver.
Har udført 1000 opgaver.
Har udført 1200 opgaver.
```

### Øvelser

- Åbn `Exercises/basic-numbers/src/KVP.LearnCSharp.Numbers.sln`.
- Navigér til `Tests.cs`.
- Løs opgaverne i rækkefølge.