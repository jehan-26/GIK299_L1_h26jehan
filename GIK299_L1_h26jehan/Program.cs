bool kor = true;
while (kor)
{
    Console.WriteLine();
    Console.WriteLine("1. Beräkna Wind chill-faktor");
    Console.WriteLine("2. Avsluta");
    Console.Write("Ditt val: ");
    string val = Console.ReadLine();
    switch (val)
    {
        case "1":
            // Programmet beräknar Wind chill-faktorn (WCT)
            Console.WriteLine("Wind chill-kalkylator");
            Console.WriteLine();

// Läs in temperatur
            Console.Write("Ange temperatur i Celsius: ");
            string tempText = Console.ReadLine();
            double temperatur;
            while (!double.TryParse(tempText, out temperatur))
            {
                Console.WriteLine("Ogiltig inmatning, ange ett tal.");
                Console.Write("Ange temperatur i Celsius:");
                tempText = Console.ReadLine();
            }

            Console.WriteLine($"Du angav {temperatur} grader");

// Läs in vindhastighet 
            Console.Write("Ange vindhastighet: ");
            string vindText = Console.ReadLine();
            double vindhastighet;
            while (!double.TryParse(vindText, out vindhastighet))
            {
                Console.WriteLine("Ogiltig inmatning, ange ett tal.");
                Console.Write("Ange vindhastighet: ");
                vindText = Console.ReadLine();
            }

// Fråga vilken enhet
            Console.Write("Är vindhastigheten i km/h eller m/s? (skriv 1 för km/h, 2 för m/s): ");
            string enhet = Console.ReadLine();

// Om m/s, räkna om till km/h
            if (enhet == "2")
            {
                vindhastighet = vindhastighet * 3.6;
            }

            Console.WriteLine($"Vindhastighet i km/h: {vindhastighet}");

// Beräkna Wind chill-temperaturen (WCT) enligt formeln
            double wct = 13.12 + 0.6215 * temperatur - 11.37 * Math.Pow(vindhastighet, 0.16) +
                         0.3965 * temperatur * Math.Pow(vindhastighet, 0.16);

// Skriv ut resultatet med en decimal
            Console.WriteLine();
            Console.WriteLine($"Wind chill-faktorn är {wct.ToString("F1")} grader.");

// Klassificera WCT-värdet med en if-else-kedja
            if (wct > -25)
            {
                Console.WriteLine("Kallt");
            }
            else if (wct >= -35)
            {
                Console.WriteLine("Mycket kallt");
            }
            else if (wct >= -60)
            {
                Console.WriteLine("Risk för frostskada");
            }
            else
            {
                Console.WriteLine("Stor risk för frostskada");
            }

            break;
        case "2":
            Console.WriteLine("Hej då!");
            kor = false;
            break;
        default:
            Console.WriteLine("Ogiltigt val, försök igen.");
            break;
    }
}