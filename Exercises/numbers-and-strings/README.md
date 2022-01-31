## Tal og tekst

Tekst og tal er blandt de basale datatyper, som vi bruger hele tiden i programmering. Der er to tekst-typer, 10 heltalstyper (ja, hele 10 typer kun til tal uden decimaler) og 3 typer til decimaltal. 

Men lad os holde os til de nødvendige (og klart mest hyppigt forekommende) lige nu:

| Datatype  | Navn                                            | Kategori  | Størrelse          | Beskrivelse                                                                       | 
| --------- | ----------------------------------------------- | --------- | ------------------ | --------------------------------------------------------------------------------- |
| `string`  | Streng (string)                                 | Reference | Dynamisk (max 2GB) | En tekst.                                                                         |
| `char`    | Karakter (character)                            | Værdi     | 16 bits            | 1 unicode karakter.                                                               |
| `int`     | Heltal (integer)                                | Værdi     | 32 bits            | Et heltal fra -2.147.483.648 til 2.147.483.647                                    |
| `long`    | Stort heltal (long integer)                     | Værdi     | 64 bits            | Et heltal fra -9.223.372.036.854.775.808 til 9.223.372.036.854.775.807            |
| `float`   | Flydende decimaltal (floating point number)     | Værdi     | 32 bits            | Fysiske og naturlige decimaltal med uendelig decimalrække og aftagende præcision. |
| `double`  | Dobbelt præcisionstal (double precision number) | Værdi     | 64 bits            | Enorme eller meget små naturlige decimaltal.                                      |
| `decimal` | Decimaltal (decimal number)                     | Værdi     | 128 bits           | Kunstige decimaltal med endelig decimalrække og høj præcision.                    |

### Konkrete værdier (literal values)

Når vi skal angive en type indenfor en konkret type, så er der bestemt formater vi anvender. Man kunne måske tro, at erklæringen af typen var nok, men somme tider anvender vi en konkret værdi uden en forudgående, utvetydig erklæring. Når vi f.eks. bruger `var`-formen til at eklære en variabel, ville det ikke være muligt at skelne om det er `int` eller `long` der tilsigtes, hvis tallet ikke overstiger grænsen for `int`. Det gøres med den konkrete form.

```csharp
// string
var myString = "Dette er min tekst.";

// char
var myChar = 'C';

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

Man kan godt blande taltyper i et samlet matematisk udtryk, men det er farligt terræn, som man bør kende godt, før man gør det. Eksempelvis er der også en divisionsoperator for `int`, men den fjerner alle decimaler i resultatet. Lad os prøve ovenstående udregning uden eksplicitte typer:

```csharp
double fahrenheit = 50.00;
double celsius = (fahrenheit - 32) * (5 / 9);
System.Console.WriteLine(celsius);
```

Nu udskriver den:

```
0
```

Den første parentes `(fahrenheit - 32)` går fint, fordi `double - int = double`, men i evalueringen af den anden parentes har vi `int / int = int`, så `(5 / 9) = 0`. Når vi ganger det øvrige udtryk ind, ender det hele som `0`.

#### Andre operatorer og `Math`

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

#### Opdatering af variabel

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

Hvis man anvender blandede typer i et udtryk, skal man sikre sig, at den resulterende værdi er af den ønskede type. Dette vil ikke kompilere:

```csharp
int x = 7;
x = x / 10.5;
```

Fejlen er `Cannot implicitly convert 'double' to 'int'`. Da `int / double = double`, kan x ikke modtage værdien. Vi vil senere lære måder at håndtere dette problem.

#### Operatorers præcedens

Præcedensen af operatorer er som i matematikken - multiplikation før plus osv. Hvis man bliver i tvivl om præcedens, bør man tilføje parenteser. De er altid tilladt i udtryk. Senere kommer der nye operatorer (fx de boolske operatorer), og på det tidspunkt vil vi genbesøge præcedens.

Se eventuelt [den fulde tabel over operator-præcedens i C#](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/#operator-precedence).

### `char` og `string`

Tekst er simplest i den forstand, at der kun findes to datatyper til at angive tekst: `char`, der svarer til et enkelt tegn, og `string`, der svarer til flere tegn, mange tegn, potentielt set hele bøger i en enkelt variabel.

```csharp
char myCharacter = 'B';
string myText = "This is a text.";
```

#### Den specielle værdi `null`

Som det fremgår af ovenstående tabel, er kun `string` i kategorien "Reference-type". Alle de øvrige er "Værdi-typer". De præcise implikationer af dette er vidtrækkende, men lige nu skal vi ikke vide andet end, at reference-typer udover deres typebestemte værdirum også kan være den specielle værdi `null`.

Dette betyder grundlæggende, at variablen kan have en værdi, eller være ingenting.

```csharp
string myString = null;
```

#### Newline

#### Escape character

### `string`-metoder

```csharp
// Substring skærer en del af teksten ud, baseret på start- og slutposition.
"Hello there".Substring(2)              // = "llo there"
"Hello there".Substring(2, 3)           // = "llo"

// Replace 

// Trim, TrimStart og TrimEnd fjerner whitespace før og efter
"      Hello there   ".TrimStart();     // = "Hello there   "
"      Hello there   ".Trim();          // = "Hello there"

```