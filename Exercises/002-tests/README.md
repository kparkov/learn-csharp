## Tests

God kode er _modulær_, _uafhængig_ og opdelt på en måde, så den enkelte del kun har ansvar for en enkelt ting.

Når koden har disse egenskaber, betyder det blandet andet, at den enkelte del kan tages ud og undersøges separat, dvs. udenfor sin tilsigtede kontekst. Dette gør delene (og derfor hele koden) _testbar_.

Tests er antagelser om den færdige kode: hvis jeg giver dette input, hvilket output forventer jeg så? Faktisk er antagelserne ofte tilvirket fra noget stærkere end antagelser: tests er en formalisering af kravene til softwaren. Tests er i sig selv en del af koden, som kun er relevant i udviklingen og valideringen af softwaren, og derfor ikke en del af leverancen som sådan.

Der kommer flere og flere tests til. En test kan indeholde én eller flere antagelser, men testen som helhed kan enten bestå eller fejle. Hvis blot én af de indeholdte antagelser i testen er forkert, vil hele testen fejle. Hvis blot én test fejler, kan softwaren ikke betragtes som værende i en fungerende tilstand, hvis en eller flere tests fejler. Det omvendte kan desværre ikke konkluderes: selvom alle tests er bestået, er softwaren ikke nødvendigvis fungerende - **men** hvis der er skrevet tests til alle dele af koden, så er det en stærk indikation, når alle tests er bestået.

Tests forbliver en permanent del af koden, så længe koden eksisterer. Det er klart, at der også kan være fejl i tests (fejlantagelser). Det er også klart, at tests kan ændre sig som svar på ændrede krav.

### Sådan anvender vi tests fremadrettet

Tests er velegnede til disse øvelser, og fremadrettet bliver dette en velkendt form: jeg har skrevet tests, du skal forsøge at få dem til at bestå. Der er dermed i øvelserne to dele:

- modulet, som enten 1) ikke er skrevet, 2) kun er delvist skrevet eller 3) er skrevet, men indeholder fejl. Det er her, du skal skrive din kode.
- en eller flere tests, der beskriver målet for din udvikling, og som skal bestås før opgaven er færdig.