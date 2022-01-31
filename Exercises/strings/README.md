## Introduktion til tekst

Tekst-strenge er også meget hyppigt anvendte i alle programmer. De bruges naturligvis i høj grad til data, der skal læses og forstås af en bruger, men vi bruger også ofte tekst til at bære mere komplekse, maskinforståelige datastrukturer. Fx sker al kommunikation via en web-browser med tekst-formater, herunder fx JSON, XML eller HTML.

| Datatype  | Navn                                            | Kategori  | Størrelse          | Beskrivelse                                                                       | 
| --------- | ----------------------------------------------- | --------- | ------------------ | --------------------------------------------------------------------------------- |
| `string`  | Streng (string)                                 | Reference | Dynamisk (max 2GB) | En tekst.                                                                         |
| `char`    | Karakter (character)                            | Værdi     | 16 bits            | 1 unicode karakter.                                                               |

`char` kan altså kun repræsentere 1 unicode-tegn, mens en enkelt `string`-variabel kan indeholde flere tusinde romaner.

### Konkrete værdier

`string` angives med dobbelt anførselstegn, og `char` med enkelt anførselstegn.

```csharp
// string
var myString = "Dette er min tekst.";

// char
var myChar = 'C';
```
### `string` som reference og den specielle værdi `null`

Som det fremgår af ovenstående tabel, er `string` i kategorien "Reference-type". De øvrige vi har set på hidtil er "Værdi-typer". De præcise implikationer af dette er vidtrækkende, men lige nu skal vi ikke vide andet end, at reference-typer udover deres typebestemte værdirum også kan være den specielle værdi `null`, der svarer til fraværet af en værdi.

```csharp
string myString = null;
```

### 