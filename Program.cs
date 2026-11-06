Random zufall = new Random();
bool nochmalsSpielen = true;

while (nochmalsSpielen)
{
    int spielerLeben = 100;
    int spielerMaxLeben = 100;
    int heilungenUebrig = 3;
    int spezialUebrig = 1;
    int besiegteMonster = 0;

    Console.Clear();
    Console.WriteLine("===================================");
    Console.WriteLine("        MONSTER-KAMPF");
    Console.WriteLine("===================================");

    while (spielerLeben > 0)
    {
        // Monster auswählen
        string monsterName;
        int monsterLeben;
        int monsterMinSchaden;
        int monsterMaxSchaden;

        int wurf = zufall.Next(1, 101);

        if (wurf <= 50)
        {
            monsterName = "Goblin";
            monsterLeben = 30;
            monsterMinSchaden = 3;
            monsterMaxSchaden = 8;
        }
        else if (wurf <= 85)
        {
            monsterName = "Shrek";
            monsterLeben = 60;
            monsterMinSchaden = 8;
            monsterMaxSchaden = 14;
        }
        else
        {
            monsterName = "Drache";
            monsterLeben = 100;
            monsterMinSchaden = 12;
            monsterMaxSchaden = 20;
        }

        Console.WriteLine();
        Console.WriteLine($"Ein wilder {monsterName} erscheint! ({monsterLeben} LP)");

        // Kampf
        while (spielerLeben > 0 && monsterLeben > 0)
        {
            Console.WriteLine();
            Console.WriteLine("Was willst du tun?");
            Console.WriteLine("1 = Angreifen");
            Console.WriteLine($"2 = Heilen ({heilungenUebrig}x übrig)");
            Console.WriteLine($"3 = Spezialangriff ({spezialUebrig}x übrig)");
            Console.Write("Deine Wahl: ");
            string eingabe = Console.ReadLine();

            if (eingabe == "1")
            {
                int schaden = zufall.Next(10, 21);
                monsterLeben -= schaden;
                Console.WriteLine($"Du greifst an und machst {schaden} Schaden!");
            }
            else if (eingabe == "2")
            {
                if (heilungenUebrig > 0)
                {
                    int heilung = 30;
                    spielerLeben += heilung;
                    if (spielerLeben > spielerMaxLeben)
                    {
                        spielerLeben = spielerMaxLeben;
                    }
                    heilungenUebrig--;
                    Console.WriteLine($"Du heilst dich! Du hast jetzt {spielerLeben} LP.");
                }
                else
                {
                    Console.WriteLine("Fehler: Du kannst dich nicht mehr heilen!");
                    continue;
                }
            }
            else if (eingabe == "3")
            {
                if (spezialUebrig > 0)
                {
                    int schaden = 50;
                    monsterLeben -= schaden;
                    spezialUebrig--;
                    Console.WriteLine($"SPEZIALANGRIFF! Du machst {schaden} Schaden!");
                }
                else
                {
                    Console.WriteLine("Fehler: Du hast den Spezialangriff schon benutzt!");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("Fehler: Ungültige Eingabe! Bitte 1, 2 oder 3 eingeben.");
                continue;
            }

            if (monsterLeben > 0)
            {
                int monsterSchaden = zufall.Next(monsterMinSchaden, monsterMaxSchaden + 1);
                spielerLeben -= monsterSchaden;
                Console.WriteLine($"Der {monsterName} greift an und macht {monsterSchaden} Schaden!");
            }

            if (monsterLeben < 0) monsterLeben = 0;
            if (spielerLeben < 0) spielerLeben = 0;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Du: {spielerLeben} LP   |   {monsterName}: {monsterLeben} LP");
            Console.WriteLine("-----------------------------------");
        }

        if (monsterLeben <= 0)
        {
            besiegteMonster++;
            Console.WriteLine($"Du hast den {monsterName} besiegt!");
        }
    }

    // Spielende
    Console.WriteLine();
    Console.WriteLine("===================================");
    Console.WriteLine("           GAME OVER");
    Console.WriteLine($"  Besiegte Monster: {besiegteMonster}");
    Console.WriteLine("===================================");

    string antwort = "";
    while (antwort != "j" && antwort != "n")
    {
        Console.Write("Möchtest du nochmals spielen? (j/n): ");
        antwort = Console.ReadLine().ToLower();

        if (antwort != "j" && antwort != "n")
        {
            Console.WriteLine("Fehler: Bitte nur j oder n eingeben.");
        }
    }

    nochmalsSpielen = (antwort == "j");
}

Console.WriteLine("Danke fürs Spielen!");