### Editor, projektstruktur og syntaks (20 min)

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

### Variabler og udtryk

I det imperative programmeringsparadigme anskuer vi programmet og maskinen som en øjeblikstilstand, der ved applicering af en transformativ logik bringes i en ny øjeblikstilstand. Bevægelsen er _diskret_, dvs trinvis mellem adskilte tilstande (modsat en kontinuert, glidende og analog tilstandsforandring).

`tilstand A -> handling -> tilstand B -> handling -> tilstand C`

Tilstandens atom er variablen. En variabel er en navngivet kasse i (arbejds)hukommelsen, hvor vi kan gemme en værdi til senere brug. Vi anvender navnet for at referere til den indeholdte værdi. Værdien bag variablen kan skifte, mens navnet forbliver det samme.

En variabel _erklæres_ (declaration) altid med en type og et navn.

```csharp
// Jeg erklærer / der er et heltal (integer), der hedder 'x'.
int x;
```

En variabel kan _initialiseres_ til et _udtryk_ (expression) i samme ombæring. Et udtryk _kan evalueres_ til en enkelt værdi. Værdier er dermed udtryk, men et udtryk er ikke nødvendigvis en værdi.

```csharp
// Der er et heltal, der hedder 'x', og det har værdien 7.
int x = 7;

// Der er et heltal, der hedder 'y', og det har værdien, der er resultatet af 10 + 8.
int y = 10 + 8;

System.Console.WriteLine(y);
```

Dette producerer følgende output:

```sh
18
```

Et udtryk siges at være boolsk (boolean), hvis der anvendes en boolsk operator. Et boolsk udtryk ender altid med at være enten sandt eller falsk. Boolske udtryk er centrale for kontrolstrukturen i alle programmer.

```csharp
int age = 42;

bool isChild = age < 18;

// isChild = 42 < 18
// isChild = false

bool isReadyForRetirement = age >= 65;

// isReadyForRetirement = 42 >= 65
// isReadyForRetirement = false

bool isExactlyTwenty = age == 20;

// isExactlyTwenty = 42 == 20
// isExactlyTwenty = false

bool isTeenager = age >= 13 && age < 20;

// isTeenager = 42 >= 13 && 42 < 20
// isTeenager = true && 42 < 20
// isTeenager = true && false
// isTeenager = false

bool isChildOrReadyForRetirement = age < 18 || age >= 65;

// isChildOrReadyForRetirement = 42 < 18 || 42 >= 65
// isChildOrReadyForRetirement = false || 42 >= 65
// isChildOrReadyForRetirement = false || false
// isChildOrReadyForRetirement = false

bool paysFullPrice = age >= 13 && !isReadyForRetirement;

// paysFullPrice = 42 >= 13 && !isReadyForRetirement
// paysFullPrice = true && !isReadyForRetirement
// paysFullPrice = true && !false
// paysFullPrice = true && true
// paysFullPrice = true
```

Der er et udvalg af primitive typer, hvoraf vi til at starte med kigger på `string` (tekst), `int` (heltal), `bool` (sandt/falsk), `double` (decimaltal med flydende decimaler) og `decimal` (decimaltal med faste decimaler).

```csharp
string president = "Vladimir Putin";
int birthyear = 1985;
bool doorIsOpen = true;
double pi = 3.1415;
decimal balance = 1275.50m;
```

En variabel kan opdateres efter erklæring. Dette 

```csharp
int x = 0;
int y = 5;
int z = 10;

x = y + z;
```

Når et udtryk er en kombination af værdier, variabler og operatorer, der kan evalueres til en enkelt værdi, vil det blive evalueret med det samme. Værdien, som er resultatet, gemmes under variablen, men forholdet / udtrykket kasseres efter evaluering. 

Dette er en af de karakteristiske forskelle på variabler og funktioner.

I det følgende vises et aritmetisk udtryk:

```csharp
double pi = 3.1415;
double radius = 7;
double circumference = 2 * radius * pi;
```

Konsekvensen af den øjeblikkelige evaluering er, at hvis vi senere ændrer `radius`, så forbliver `circumference` uændret.


### Afrunding (10 min)

- Github: hvordan I kan gemme løsningen på jeres øvelser til senere.
- Repetitionsøvelser. I kan løse dem nu eller til næste gang.
- Førstehåndsindtryk
  - Fungerer formen?
  - Er 2 timer passende? Skal vi eventuelt skrue op eller ned?