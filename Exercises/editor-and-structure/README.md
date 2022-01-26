## Editor og projektstruktur

### Project og solution

Vi bruger enten Visual Studio (VS) eller Rider (RDR). De to editorer har overordnet de samme features.

Den overordnede løsning, som man åbner i editoren, er enten et _project_ (extension `.csproj`) eller en _solution_ (extension `.sln`).

Et **project** er en række kodefiler fordelt i mapper, som fungerer som en samlet, logisk enhed. Denne enhed kan være et stykke færdig software, men kan også være et _library_ af kode, som er møntet på at blive anvendt af anden kode.

En **solution** er flere projekter, som åbner sammen og hvor de enkelte projekter har afhængigheder af andre, dvs projekterne anvender hinanden. 

Fx kan ét projekt være en datamodel, mens det næste er en frontend til datamodellen via web, et andet er en applikation der kan installeres, osv. De enkelte projekter kan startes hver især, undtagen selve datamodellen, som blot servicerer de andre.

### Editorens overordnede dele

Her beskriver vi editorens vigtigste dele, som skal anvendes hyppigt i det følgende.

#### Solution Explorer / Explorer

Et træ, hvor vi på øverste niveau kan se projekterne, og herunder folder- og filstrukturen. Vi kan dobbeltklikke på en kodefil (som har extension `.cs`) for at åbne den i editoren.

#### Editor

Når vi dobbeltklikker på en fil, åbner den op i editoren. Det er her vi læser og skriver kode. Editoren åbner i en fane. Der kan være mange kodefiler åbne samtidig.

#### Test Explorer / Unit Tests

Dette vindue viser alle unit tests, som er defineret i løsningen, samt hvilke tests der bestod eller fejlede sidste kørsel.

#### Konsol-vindue / Run

Når vi kører et konsolprojekt, starter det op i dette vindue. I VS er det et eksternt vindue, mens det i RDR er et område i applikationsvinduet.

### Det minimale program

Det minimale program ser som udgangspunkt sådan ud:

```csharp
using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Hello, world!");
        }
    }
}
```

Det udskriver 

### Kodestruktur

Det ovenstående, og alle andre C#-programmer, er opbygget omkring udsagn, der antager disse to meget typiske former:

```csharp
<udsagn>;
```

Et udsagn er en komplet og meningsfuld sætning i kode, der kan eksekveres / udføres.

Alternativt har det formen:


```csharp
<udsagn> 
{
    <indlejret kode>
}
```

Her er `udsagn` overordnet `indlejret kode` (som i sig selv også er en række udsagn), og man kan derfor sige at den indlejrede kode sker i konteksten af det udsagn, der startede tuborg og indrykning. En sådan kontekst kaldes en _kodeblok_ og/eller et _scope_.

_Det er en konvention, at vi indrykker kode, der er inde i en kodeblok. Det er en visuel hjælp. Det er ikke påkrævet for at virke, men det er en fuldstændig indiskutabel standard._

Dette leder altså f.eks. til en struktur, der spejler det ovenstående program.

```csharp
<udsagn>;

<udsagn>
{
    <udsagn> 
    {
        <udsagn>
        {
            <udsagn>;
        }
    }
}
```

Når vi kommer længere frem, bliver sådanne strukturer længere og mere komplekse, men vil overordnet set være opbygget af samme klodser.

```csharp
<udsagn>;
<udsagn>;
<udsagn>;
<udsagn>;

<udsagn> 
{
    <udsagn> 
    {
        <udsagn>
        {
            <udsagn>;
            <udsagn>;
            <udsagn>;

            <udsagn>
            {
                <udsagn>;
                <udsagn>;
            }

            <udsagn>
            {
                <udsagn>;

                <udsagn>
                {
                    <udsagn>;
                }
            }
        }

        <udsagn>
        {
            <udsagn>
            {
                <udsagn>;
                <udsagn>;

                <udsagn>;
                <udsagn>;
                <udsagn>;

                <udsagn>; <udsagn>; <udsagn>;
            }

            <udsagn>
            {
                <udsagn>;

                <udsagn>
                {
                    <udsagn>;
                }
            }
        }
    }
}
```

Det er vigtigt at bemærke, at alle former for _whitespace_ (tabs, mellemrum, linieskift) kun er for læsbarheden. Det er kun semikolon og tuborgklammer der adskiller udsagn.

### Det minimale program i alternativ form

Du kommer til at støde på et endnu kortere format for et program. Det er nemlig tilladt i nyere versioner af sproget at skrive det minimale program på denne simple måde:

```csharp
Console.WriteLine("Hello, world!");
```

I dette format er den omkringliggende kode ikke _fraværende_, den er _implicit_ (fordi den alligevel altid har samme struktur).

### Øvelse

Åbn projektet `src/KVP.LearnCSharp.Minimal/KVP.LearnCSharp.Minimal.csproj` i din editor.

Kør programmet og bekræft, at det kan køre, og at teksten dukker korrekt op i konsollen.

Find og udforsk de forskellige områder i editoren, som er nævnt først i denne artikel.