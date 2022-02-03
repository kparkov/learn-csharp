> "I believe myself to possess a most singular combination of qualities exactly fitted to make me pre-eminently a discoverer of the hidden realities of nature."  
>
> Ada Lovelace (1815 - 1852), verdens første programmør 

## Bool'ske udtryk

En boolean (`bool`) er den mest elementære datatype, og svarer til den korteste information mulig, 1 bit. Den er enten `true` eller `false`, men kan også bruges til andre binære svar - tændt / slukket, ja / nej, etc. 

Et boolsk udtryk (boolean expression) er et udtryk, der evalueres til en boolsk værdi. Resultatet af et boolsk udtryk er `true` eller `false`. Det er på denne måde analogt til et aritmetisk udtryk, der kan evalueres til en numerisk værdi. Boolske udtryk er centrale for _kontrolstrukturen_ i alle programmer. Boolske udtryk kan indeholde boolske værdier, men kan også produceres ud fra andre datatyper i kombination med _relationelle operatorer_.

Kontrolstrukturen styrer den overordnede eller detaljerede retning i programmet, dvs forgreningerne i programmet. Alle forgreninger i et program er baseret på et boolsk udtryk - hvis A er sandt, så 1; hvis falsk, så 2. Et valg med flere forgreninger end to kan reduceres til et boolsk valg: hvis A er sandt, så 1; hvis falsk, så hvis B er sandt, så 2; hvis falsk, så 3. Denne helt basale kontrolstruktur kaldes `if / else` (to udfald) eller `if / else if / else` (flere udfald).

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

Forskellen i de logiske operatorer kan illustreres med en sandhedstabel.

| `p`     | `q`     | `!p`    | `p && q` | <code>p &#124;&#124; q</code> | `p ^ q` |
| ------- | ------- | ------- | -------- | ----------------------------- | ------- |
| `true`  | `true`  | `false` | `true`   | `true`                        | `false` |
| `true`  | `false` | `false` | `false`  | `true`                        | `true`  |
| `false` | `true`  | `true`  | `false`  | `true`                        | `true`  |
| `false` | `false` | `true`  | `false`  | `false`                       | `false` |

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

bool shouldPayFullPrice = age >= 13 && !isReadyForRetirement;

// shouldPayFullPrice = 42 >= 13 && !isReadyForRetirement
// shouldPayFullPrice = true && !isReadyForRetirement
// shouldPayFullPrice = true && !false
// shouldPayFullPrice = true && true
// shouldPayFullPrice = true
```
### De Morgans love

Vi kan vende et helt udtryk om med NOT-operatoren. Hvis `x && y` er sandt, hvis både `x` og `y` er sandt, så er `!(x && y)` sand, hvis de _ikke_ begge er sande. Dette er logisk ækvivalent til `(!x || !y)`, som er sandt, hvis enten x eller y ikke er sande.

Disse regler for invertering kaldes De Morgans love:

```csharp
!(x || y) == (!x && !y)
!(x && y) == (!x || !y)
```

Det som De Morgans love bedst illustrerer er, at det samme udtryk kan siges på flere måder, og der er meget stor forskel på, om det er menneskeligt / intuitivt forståeligt.

### Sandhedstabeller




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

Der kan være flere `else if`-blokke. Kun ét af alle de mulige udfald kan blive eksekveret, og mere bestemt den første positive betingelse vil lede til eksekvering - også selvom flere betingelser i rækken er opfyldt.