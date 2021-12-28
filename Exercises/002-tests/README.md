## Tests

God kode er _modulær_, hvilket vil sige, at den er logisk afgrænset, og uafhængig af at blive anvendt i en bestemt kontekst. Kodens enkelte dele overholder desuden også dette krav om modularitet, således, at der er tale om . 

### Case: solsystem-modellen

Lad os forestille os kode, der simulerer bevægelse i et fysisk system, f.eks. solsystemet.

I solsystemet har vi solen i midten, og en række planeter. Planeterne har desuden måner. Månerne kredser om planeterne, planeterne rundt om solen. Men vi opdager hurtigt, at alle disse fysiske objekter er af lignende beskaffenhed, og følger cirka de samme regler. De har det samme _sæt af egenskaber_, selvom de egenskaber selvfølgelig har _individuelle værdier_.

Vi beslutter, at modellen følger Newtonian physics. Vi kan se, at vi kan identificere tre uafhængige typer, som skal defineres, og som kan testes adskilt i vores fysiske system: 

- `Vector`: en type, der er defineret ved XYZ-koordinater, og som bruges til at angive position i 3D-rum, men også hastighed og endda acceleration. `X`, `Y` og `Z` er primitive / indbyggede typer.
- `CelestialBody`: en type, der bruges til at definere sol, planeter og måner. De har et navn (`string`), en kategori (`string`), diameter (`double`) og vægt (`double`). Alle primitive / indbyggede typer. Og så har de position og hastighed, der begge er `Vector`, dvs vores egen, indbyggede type.
- `Space`: rummet er den sidste type, vi definerer, og svarer til det overordende, fysiske system, hvor de enkelte 

### Blackbox tests / unit tests

Før vi skriver en linie kode til de ovenstående overvejelser, starter vi med at skrive en test af `Vector`-typen.

Tests er kode, der antager ting, om den kode vi skal til at skrive. Vektorer er veldefinerede matematiske størrelser, og vi kan uden videre oversætte disse regler til antagelser om den færdige kode.

F.eks. antager jeg 

