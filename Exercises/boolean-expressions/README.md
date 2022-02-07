> "I believe myself to possess a most singular combination of qualities exactly fitted to make me pre-eminently a discoverer of the hidden realities of nature."  
>
> Ada Lovelace (1815 - 1852), verdens første programmør 

## Bool'ske udtryk

En boolean (`bool`) er den mest elementære datatype, og svarer til den korteste information mulig: 1 bit. Den er enten `true` eller `false`, men kan også bruges til andre binære svar - tændt / slukket, ja / nej, etc. 

Et boolsk udtryk (boolean expression) er et udtryk, der evalueres til en boolsk værdi. Resultatet af et boolsk udtryk er `true` eller `false`. Det er på denne måde analogt til et aritmetisk udtryk, der kan evalueres til en numerisk værdi. Boolske udtryk er centrale for _kontrolstrukturen_ i alle programmer. Boolske udtryk kan indeholde boolske værdier, men kan også produceres ud fra andre datatyper i kombination med _relationelle operatorer_.

Kontrolstrukturen styrer den overordnede eller detaljerede retning i programmet, dvs forgreningerne i programmet. Alle forgreninger i et program er baseret på et boolsk udtryk: 

- hvis A er sandt, så 1
- hvis falsk, så 2. 

Et valg med flere forgreninger end to kan reduceres til et boolsk valg: 

- hvis A er sandt, så 1
- hvis falsk, så: 
  - hvis B er sandt, så 2 
  - hvis falsk, så 3. 

Denne helt basale kontrolstruktur kaldes `if / else` (to udfald) eller `if / else if / else` (flere udfald).

Det enkleste boolske udtryk er at sætte en variabel til en boolsk værdi (boolean value):

```csharp
bool itIsMyBirthday = false;
```

Vi kan producere en boolsk værdi med et boolsk udtryk. Et boolsk udtryk er et udtryk, der anvender boolske operatorer:


```csharp
int age = 42;
bool isChild = age < 18;
```

Her anvender vi den boolske operator `<` (mindre end / less than) i udtrykket `age < 18`, som betyder "alder er mindre end 18". Udtrykket kan enten være sandt eller falsk, og evalueringen vil foregå således:

```
age = 42
isChild = age < 18
isChild = 42 < 18
isChild = false
```

`isChild` er falsk, fordi påstanden "42 er mindre end 18" er falsk.

`<` er en _relationel_ operator, der sammenligner to størrelser. Der findes også _logiske_ operatorer, der kombinerer flere betingelser på forskellige måder.

De relationelle operatorer er som følger (ved fortsat brug af `age`-eksemplet):

- LESS THAN (`<`): `age < value` er sandt, hvis `age` er mindre end `value`.
- GREATER THAN (`>`): `age > value` er sandt, hvis `age` er større end `value`.
- LESS THAN OR EQUAL (`<=`): `age <= value` er sandt, hvis `age` er mindre end eller lig med `value`.
- GREATER THAN OR EQUAL (`>=`): `age >= value` er sandt, hvis `age` er større end eller lig med `value`.
- EQUAL (`==`): `age == value` er sandt, hvis `age` er præcis lig med `value`.
- NOT EQUAL (`!=`): `age != value` er sandt, hvis `age` ikke er lig med `value`.


De logiske operatorer sammenføjer to boolske udtryk. Lad os forestille os, at vi har to `bool`s, `isHungry` og `hasFood`:

- AND (`&&`): `isHungry && hasFood` er sandt, hvis vi **både** er sultne og har mad.
- OR (`||`): `isHungry || hasFood` er sandt, hvis vi **enten** er sultne eller har mad.
- NOT (`!`): `!isHungry` er sandt, hvis vi ikke er sultne.
- XOR (`^`): `isHungry ^ hasFood` er sand, hvis vi er sultne _eller_ har mad, _men ikke begge_. Dette kaldes _exclusive or_.

#### Sandhedstabeller

Forskellen i de logiske operatorer kan illustreres med en sandhedstabel. Vi tager udgangspunkt i to boolske udtryk, `p` og `q`, og viser så resultatet af NOT, AND, OR og XOR. Bemærk at NOT kun opererer på ét udtryk `p`, mens de andre opererer på begge.

| `p`     | `q`     | `!p` (NOT) | `p && q` (AND) | <code>p &#124;&#124; q</code> (OR) | `p ^ q` (XOR) |
| ------- | ------- | ---------- | -------------- | ---------------------------------- | ------------- |
| `true`  | `true`  | `false`    | `true`         | `true`                             | `false`       |
| `true`  | `false` | `false`    | `false`        | `true`                             | `true`        |
| `false` | `true`  | `true`     | `false`        | `true`                             | `true`        |
| `false` | `false` | `true`     | `false`        | `false`                            | `false`       |

### Eksempler på blandet brug

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

bool isExactlyFourtyTwo = age == 42;

// isExactlyFourtyTwo = 42 == 42
// isExactlyFourtyTwo = true

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

bool shouldPayFullPrice = age >= 13 && !isReadyForRetirement; // Bemærk! Anvender værdi ovenfor!

// shouldPayFullPrice = 42 >= 13 && !isReadyForRetirement
// shouldPayFullPrice = true && !isReadyForRetirement
// shouldPayFullPrice = true && !false
// shouldPayFullPrice = true && true
// shouldPayFullPrice = true
```
### De Morgans love

Vi kan vende et helt udtryk om med NOT-operatoren. `p && q` er sandt, hvis både `p` og `q` er sandt, så `!(p && q)` er sand, hvis de _ikke_ begge er sande. Dette er logisk ækvivalent til `(!p || !q)`, som er sandt, hvis enten `p` eller `q` ikke er sande.

Disse regler for invertering kaldes De Morgans love:

```csharp
!(p || q) == (!p && !q)
!(p && q) == (!p || !q)
```

Når et boolsk udtryk forekommer uforståeligt, kan det somme tider betyde, at det ikke lader sig forklare med enkelt, naturligt sprog. De Morgans Love viser os, at et sådant udtryk ofte kan rekonstrueres i et mere læseligt format.

### Kontrolstrukturen `if / else if / else`

Vi kan benytte booleans og boolske udtryk i `if / else if / else`-strukturen. Den simpleste form er som følger, hvor vi kun anvender `if`:

```csharp
bool doorIsOpen = true;

System.Console.WriteLine("Døren er...");

if (doorIsOpen) 
{
    System.Console.WriteLine("ÅBEN!");
    System.Console.WriteLine("Kom indenfor!"); 
}

System.Console.WriteLine("Programmet er slut.");
``` 

Outputtet bliver:

```
Døren er...
ÅBEN!
Kom indenfor!
Programmet er slut.
```

Men hvis vi ændrer koden, så `doorIsOpen` initialiseres til `false`, så vil outputtet være:

```
Døren er...
Programmet er slut.
```

Koden i `if`-blokken eksekverer, hvis udtrykket i parentesen efter `if` er sand. Uanset om koden eksekverer eller ej, fortsætter programmet bagefter på den anden side af kodeblokken.

Da det virker lidt uafsluttet, når betingelsen er falsk, kan vi skrive en alternativ strategi for dette tilfælde, kaldet `else`:

```csharp
bool doorIsOpen = false;

System.Console.WriteLine("Døren er...");

if (doorIsOpen) 
{
    System.Console.WriteLine("ÅBEN!");
    System.Console.WriteLine("Kom indenfor!"); 
}
else
{
    System.Console.WriteLine("LUKKET!");
    System.Console.WriteLine("Bliv ude!"); 
}

System.Console.WriteLine("Programmet er slut.");
```

Nu vil `else`-blokken altid blive ramt, hvis `if`-blokken ikke bliver det. Det nye output bliver:

```
Døren er...
LUKKET!
Bliv ude!
Programmet er slut.
```

Dette giver en enten/eller udfald. Den kan udvides med yderligere muligheder i den fulde `if / else if / else`-konstruktion.

```csharp
bool doorIsOpen = false;
bool isOwner = true;

System.Console.WriteLine("Døren er...");

if (doorIsOpen) 
{
    System.Console.WriteLine("ÅBEN!");
    System.Console.WriteLine("Kom indenfor!"); 
}
else if (isOwner) 
{
    System.Console.WriteLine("Lukket, men ejeren må altid komme ind.");
    System.Console.WriteLine("Velkommen hjem.");
}
else
{
    System.Console.WriteLine("LUKKET!");
    System.Console.WriteLine("Bliv ude!"); 
}

System.Console.WriteLine("Programmet er slut.");
```

Der kan være flere `else if`-blokke. Kun ét af alle de mulige udfald kan blive eksekveret, og mere bestemt den første positive betingelse vil lede til eksekvering - også selvom flere betingelser i rækken er opfyldt. `else`-blokken er stadig valgfri, og kører kun, når ingen betingelser var opfyldt.

```csharp
int age = 13;
decimal price = 100m;

if (age <= 5)
{
    price = 0m;
}
else if (age <= 15)
{
    price = 20m;
}
else if (age <= 25 || age >= 65)
{
    price = 50m;
}

// Hvad er prisen, når programmet er nået hertil?

```

Prisen ender med at være `20`, fordi det er den første betingelse, der er sand. Den efterfølgende betingelse (som også er sand) vil ikke engang blive tjekket. Rækkefølgen af betingelser kan derfor være afgørende.

### Tidlig `return`

Når `return` optræder i en funktion, terminerer den straks efter. Vi kan skrive `return` mange gange i en funktion, f.eks. også inde i en `if`-sætning. Dette kan hjælpe til at reducere kompleksiteten, fordi det hurtigt bliver klart, hvilke kombinationer af parametre, der er håndteret og afsluttet. 

Vi omskriver nu den ovenstående til en mere direkte læsbar udgave.

```csharp
public static decimal GetPrice(int age)
{
    if (age <= 5)
    {
        return 0m;
    }
    else if (age <= 15)
    {
        return 20m;
    }
    else if (age <= 25 || age >= 65)
    {
        return 50m;
    }
    else 
    {
        return 100m;
    }
}
```

Bemærk, at denne nye udgave eksplicitterer det forhold, at _standard-prisen er 100_, og at det er et fjerde udfald, der har sin egen betingelse (betingelsen er, at ingen af de andre betingelser er sande). Før var dette fjerde udfald implicit og skjult.

### En lille note om misanvendelse

Det er fristende at bruge booleans til alle udfald, der er binære. Hvis man f.eks. skal holde styr på, om en brik i et skakspil er sort eller hvid, kunne man vælge at implementere det som `bool isWhite` med `true` = hvid og `false` = sort. Tilsvarende er det historisk hyppigt observeret, at man har gemt personers køn med `true` = mand og `false` = kvinde (og symptomatisk nok ofte ikke omvendt...)

Undlad at anvende booleans på denne måde, medmindre hver bit tæller. Der er flere problemer med det:

- Det er ulogisk, at `isWhite = false` medfører, at brikken er sort, medmindre det anskues i sit domæne (skakspillet).
- `true` og `false` bliver pludselig komplet ubrugelige termer til at beskrive hvad data rent faktisk er. Kun sammenholdt med sit feltnavn giver det mening. Vi får senere mulighed for at bruge `enum`, som er vores egne datatype til sæt af valgmuligheder, og her kan man så definere `White`, `Black`, `Male`, `Female`, etc.
- Tilsyneladende binære valg har det med at blive non-binære, som mange, der har implementeret felter til køn har erfaret i nyere tid.
- Selv når et valg er binært, er der ofte også brug for ikke-valg som `Unspecified`, `Undecided`, `Other`, når data skal gemmes og/eller anvendes.



### Øvelser

- Åbn `/Exercises/boolean-expressions/KVP.LearnCSharp.BooleanExpressions.sln`.
- Åbn klassen `Tests.cs`, og læs opgavebeskrivelserne. 
- Alle øvelser skal løses ved at modificere `