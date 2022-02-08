## Introduktion til tekst

Tekst-strenge er også meget hyppigt anvendte i alle programmer. De bruges naturligvis i høj grad til data, der skal læses og forstås af en bruger, men vi bruger også ofte tekst til at bære mere komplekse, maskinforståelige datastrukturer. Fx sker al kommunikation via en web-browser med tekst-formater, herunder fx JSON, XML eller HTML.

| Datatype  | Navn                                            | Kategori  | Størrelse          | Beskrivelse                                                                       | 
| --------- | ----------------------------------------------- | --------- | ------------------ | --------------------------------------------------------------------------------- |
| `string`  | Streng (string)                                 | Reference | Dynamisk (max 2GB) | En tekst.                                                                         |
| `char`    | Karakter (character)                            | Værdi     | 16 bits            | 1 unicode karakter.                                                               |

`char` kan altså kun repræsentere 1 unicode-tegn, mens en `string`-variabel kan indeholde flere tusinde romaner.

### Konkrete værdier

`string` angives med dobbelt anførselstegn, og `char` med enkelt anførselstegn.

```csharp
// string
var myString = "Dette er min tekst.";

// char
var myChar = 'C';
```
### `string` som reference og den specielle værdi `null`

Som det fremgår af datatype-tabellen, er `string` i kategorien "Reference-type". De øvrige vi har set på hidtil er "Værdi-typer". De præcise implikationer af dette er vidtrækkende, men lige nu skal vi ikke vide andet end, at reference-typer udover deres typebestemte værdirum også kan være den specielle værdi `null`, der svarer til fraværet af en værdi.

```csharp
string myString = null;
```
### Konkatenering

`+` operatoren lægger to strenge sammen til en samlet streng. Denne operation kaldes _konkatenering_.

```csharp
string a = "Hello";
string b = "there!";

string concatenation = a + b;

System.Console.WriteLine(concatenation);
```

Dette udskriver:

```
Hellothere!
```

Vi skal ofte huske at sætte de rette tegn (i dette tilfælde et mellemrum) ind i konkateneringen.

```csharp
string concatenation = a + " " + b;
```

### Ækvivalens

Strenge understøtter den boolske operator `==`.

```csharp
string s = "Hello there!";

System.Console.WriteLine(s == "Hello there!");  // true
System.Console.WriteLine(s == "Hello"); // false
System.Console.WriteLine(s == "HELLO THERE!"); // false
```

Man kan alternativt bruge `.Equals` metoden, som understøtter en parameter, der specificerer om sammenligningen tager hensyn til store vs små bogstaver _(case sensitivity)_.

```csharp
string s = "Hello there!";

System.Console.WriteLine(s.Equals("Hello there!", StringComparison.CurrentCultureIgnoreCase)); // true
System.Console.WriteLine(s.Equals("HELLO THERE!", StringComparison.CurrentCultureIgnoreCase)); // true
System.Console.WriteLine(s.Equals("HELLO THERE!", StringComparison.CurrentCulture)); // false
```


### `string`-metoder

```csharp
// Substring skærer en del af teksten ud, baseret på start- og slutposition.
"Hello there!".Substring(2) // = "llo there!"
"Hello there!".Substring(2, 3) // = "llo"

// Replace 
"Hello there!".Replace("e", "i") // = "Hillo thiri!"

// Trim, TrimStart og TrimEnd fjerner whitespace før og efter
"      Hello there   ".TrimStart();     // = "Hello there   "
"      Hello there   ".Trim();          // = "Hello there"

// To upper case and lower case
"Hello there!".ToUpper() // = "HELLO THERE!"
"Hello there!".ToLower() // = ""

// Split
"Hello there!".Split("e") // = ["H","llo th","r","!"] 

```

A more complete example:

```csharp
```