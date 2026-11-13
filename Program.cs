Program · CS
Console.OutputEncoding = System.Text.Encoding.UTF8;
Random zufall = new Random();
bool nochmalsSpielen = true;
 
Console.Write("Wie heisst du? ");
string spielerName = Console.ReadLine();
if (spielerName == "")
{
    spielerName = "Spieler";
}
 
while (nochmalsSpielen)
{
    // Schwierigkeitsgrad
    int spielerMaxLeben = 0;
    while (spielerMaxLeben == 0)
    {
        Console.WriteLine();
        Console.WriteLine("Schwierigkeitsgrad wählen:");
        Console.WriteLine("1 = leicht (150 LP)");
        Console.WriteLine("2 = schwer (70 LP)");
        Console.Write("Deine Wahl: ");
        string stufe = Console.ReadLine();
 
        if (stufe == "1")
        {
            spielerMaxLeben = 150;
        }
        else if (stufe == "2")
        {
            spielerMaxLeben = 70;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fehler: Bitte 1 oder 2 eingeben.");
            Console.ResetColor();
        }
    }
 
    int spielerLeben = spielerMaxLeben;
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
 
        if (wurf <= 40)
        {
            monsterName = "Goblin";
            monsterLeben = 30;
            monsterMinSchaden = 3;
            monsterMaxSchaden = 8;
        }
        else if (wurf <= 65)
        {
            monsterName = "Skelett";
            monsterLeben = 40;
            monsterMinSchaden = 5;
            monsterMaxSchaden = 10;
        }
        else if (wurf <= 90)
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
        Console.WriteLine($"Ein wildes Monster erscheint: {monsterName}! ({monsterLeben} LP)");
 
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
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{spielerName} greift an und macht {schaden} Schaden!");
                Console.ResetColor();
            }
            else if (eingabe == "2")
            {
                if (heilungenUebrig > 0)
                {
                    spielerLeben += 30;
                    if (spielerLeben > spielerMaxLeben)
                    {
                        spielerLeben = spielerMaxLeben;
                    }
                    heilungenUebrig--;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{spielerName} heilt sich! Jetzt {spielerLeben} LP.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fehler: Du kannst dich nicht mehr heilen!");
                    Console.ResetColor();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"SPEZIALANGRIFF! {spielerName} macht {schaden} Schaden!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Fehler: Du hast den Spezialangriff schon benutzt!");
                    Console.ResetColor();
                    continue;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Fehler: Ungültige Eingabe! Bitte 1, 2 oder 3 eingeben.");
                Console.ResetColor();
                continue;
            }
 
            if (monsterLeben > 0)
            {
                int monsterSchaden = zufall.Next(monsterMinSchaden, monsterMaxSchaden + 1);
                spielerLeben -= monsterSchaden;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{monsterName} greift an und macht {monsterSchaden} Schaden!");
                Console.ResetColor();
            }
 
            if (monsterLeben < 0) monsterLeben = 0;
            if (spielerLeben < 0) spielerLeben = 0;
 
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"{spielerName}: {spielerLeben} LP   |   {monsterName}: {monsterLeben} LP");
            Console.WriteLine("-----------------------------------");
        }
 
        if (monsterLeben <= 0)
        {
            besiegteMonster++;
            Console.WriteLine($"{monsterName} wurde besiegt!");
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Fehler: Bitte nur j oder n eingeben.");
            Console.ResetColor();
        }
    }
 
    nochmalsSpielen = (antwort == "j");
}
 
Console.WriteLine("Danke fürs Spielen!");
