Problem med orginella kodbasen:
- problem 1: variabelnamnen betyder antingen inget eller används inte som man skulle tro med deras namn (programHalted används som) program aktivt
Variabelnamnen var inte deskriptiva och förklara inte vad den används för, vilket gör koden effektivt omöjlig att förstå på en snabb glans. Innan du kan förstå vad ett for loop gör måste du kolla igenom koden och bygga en mindmap av vad alla variabler är och hur de används. 

- probelm 2: nestade if statements, vilket gör det onödigt svårt att följa
Djupare nesting leder till svårare läst kod då det ser mer komplext ut än vad det egentligen är. 

- problem 3: mapp namn var icke hjälpsamt.
Mappnamnet för mappen med user.cs (modeler) gjorde det inte klart vad för typ av filer som kan hittas där, vilket gör navigering svårare. 



Förbättringar:
- felhantering
Användarnamn kan vara tomma, flera användare kan ha samma namn,

- Meny alternativen kan sättas som klasser och metoder i sina egna filer
Gör menyn enklare att arbetas på ensamt, samt gör meny valen enklare att byta plats på om sådan skulle behövas (t.ex sätta avsluta som ett senare val efter att mamn laggt till ett nytt menyval). Det gör det också enklare att jobba på individuell funktionalitet om den behövs ändras eller fixas.



Jag har lärt mig mer om hur illa det är att läsa/jobba med kod som inte är gjord med läsbarhet in mind. Det gör det betydligt svårare än nödvändigt att jobba med.

Med ändringarna jag har gjort så är det mindre gissning om vad en variabel är för och vilken data den håller vilket gör det enklare att modifiera, underhålla och expandera. Det är också enklare att följa vart du är i koden och vad den gör. 