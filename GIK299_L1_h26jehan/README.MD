# Labb 1 - Wind chill-kalkylator
## Om programmet
I den här labben har jag skapat ett konsolprogram i C# som räknar ut hur kallt det känns ute när det blåser. Programmet använder temperaturen och vindhastigheten för att beräkna Wind chill-temperaturen (WCT).
Jag har arbetat med variabler, inmatning, beräkningar, villkor och loopar.
## Så fungerar programmet
När programmet startar visas en meny med två alternativ. Användaren kan välja att beräkna Wind chill eller avsluta programmet.
Om användaren väljer att göra en beräkning för man skriva in temperaturen i Celsius och vinhastigheten. Man kan ange vindhastigheten i km/h eller m/s. Om hastigheten anges i m/s räknar programmet om den till km/h innan beräkningen görs.
Jag har använt `double`för att kunna arbeta med decimaltal och `Math.Pow()`för att beräkna upphöjt till i formeln. Resultatet visas med en decimal.
## Klassificering av resultatet 
Efter beräkningen visar programmet också hur kallt det är enligt WCT-värdet. Jag har använt `if` och `else` för att dela in resultatet i fyra kategorier:
-Kallt.
-Mycket kallt.
-Risk för frostskada.
-Stor risk för frostskada.
## Meny och felhantering 
Jag har använt en `while` -loop för att programmet ska fortsätta köras tills användaren väljer att avsluta. Jag har också använt `switch` för att hantera menyvalen.
För att kontrollera inmatningen använder jag `TryParse()`. Om användaren skriver något som inet är ett giltigt tal visar programmet ett felmeddelande och ger möjlighet att försöka igen.
## Felsökning med debuggern
Jag satte en breakpoint på raden där WCT beräknas. När programmet stannade såg jag i Variables att `temperatur` var -10 och `vindhastighet` var 10, och att `wct` inte var beräknad ännu.
Efter Step Over fick `wct` värdet -15,26 (visas som -15,3 med en decimal). Jag stegade sedan vidare och såg vilken del av if-else-kedjan som kördes.
Debuggern hjälper mig hitta fel eftersom jag kan se värdet på varje variabel medan programmet körs, i stället för att gissa var det blir fel.
## Vad jag har lärt mig
Genom den här labben har jag fått öva på att använda olika datatyper, läsa in värden från användaren och göra beräkningar i C#. Jag har också tränat på att använda villkor och loopar för att styea hur programmet fungerar.
Det har hjälpt mig att förstå hur ett program kan ta emot information, bearbeta den och visa ett resultat.