## Variabler og udtryk

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

## Øvelser

- Åbn projektet `src/KVP.LearnCSharp.Variables/KVP.LearnCSharp.Variables.csproj` i enten Visual Studio eller Rider.
- Åbn filen `Program.cs` og fortsæt med øvelsesbeskrivelserne i filen.