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

Når vi bruger 

### `char` og `string`

Tekst er simplest i den forstand, at der kun findes to datatyper til at angive tekst: `char`, der svarer til et enkelt tegn, og `string`, der svarer til flere tegn, mange tegn, potentielt set hele bøger i en enkelt variabel.

```csharp
char myCharacter = 'B';
string myText = "This is a text.";
```

#### Den specielle værdi `null`

Som det fremgår af ovenstående tabel, er kun `string` i kategorien "Reference-type". Alle de øvrige er "Værdi-typer". De præcise implikationer af 


### Operatorer



### Newline

### Escape character

