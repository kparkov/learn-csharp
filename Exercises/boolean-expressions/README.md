> "I believe myself to possess a most singular combination of qualities exactly fitted to make me pre-eminently a discoverer of the hidden realities of nature."  
>
> Ada Lovelace (1815 - 1852), verdens første programmør 

## Boolean expressions

Et udtryk siges at være boolsk (boolean), hvis der anvendes en boolsk operator. Et boolsk udtryk ender altid med at være enten sandt eller falsk. Boolske udtryk er centrale for _kontrolstrukturen_ i alle programmer.

Det enkleste boolske udtryk er at sætte en variabel til en boolsk værdi (boolean value):

```csharp
bool itIsMyBirthday = false;
```

Vi kan producere en boolsk værdi med et boolsk udtryk. Et boolsk udtryk er et udtryk, der anvender boolske operatorer:


```csharp
int age = 42;

bool isChild = age < 18;
```

Her anvender vi den boolske operator `<` (mindre end / less than) i udtrykket `age < 18`, som betyder "alder er mindre end 18". Udtrykket kan entens være sandt eller falsk, og evalueringen vil foregå således:

```
age = 42
isChild = age < 18
isChild = 42 < 18
isChild = false
```

Dvs at `isChild` vil være falsk, fordi påstanden "42 er mindre end 18" er falsk.

`<` er en _relationel_ operator, der sammenligner to størrelser. Der findes også _logiske_ operatorer, der kombinerer flere betingelser på forskellige måder.

De relationelle operatorer er som følger (ved fortsat brug af `age`-eksemplet):

- `age < value`: sandt, hvis `age` er mindre end `value`.
- `age > value`: sandt, hvis `age` er større end `value`.
- `age <= value`: sandt, hvis `age` er mindre end eller lig med `value`.
- `age >= value`: sandt, hvis `age` er større end eller lig med `value`.
- `age == value`: sandt, hvis `age` er præcis lig med `value`.
- `age != value`: sandt, hvis `age` ikke er lig med `value`.

### Datatyper og relationelle operatorer

I det ovenstående eksempel var både `age` og den sammenlignede værdi af typen `int`, og det er umiddelbart intuitivt, at et tal kan være højere, lavere eller lig med et andet tal. 

Men faktisk kan mange datatyper være genstand for sammenligning med boolean expressions. Måden de sammenlignes afhænger af typen. Fx vil to variabler af typen `string` blive sammenlignet ud fra alfabetisk (leksikografisk) sortering: `"A"` er lavere end `"B"`, osv.

Der er dog ingen garanti for, at en sammenligning kan lade sig gøre. Fx er udtrykket `true > "hej"` meningsløst, eller i hvert fald uforudsigeligt.



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

Der kan være flere `else if`-blokke. Kun ét af alle de mulige udfald kan blive eksekveret, og mere bestemt den første positive betingelse vil lede til eksekvering - også selvom