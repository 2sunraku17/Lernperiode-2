Random zufall = new Random();
int punkteSpieler = 0;
int punkteComputer = 0;
string nochmal = "j";

while (nochmal == "j")
{
    // Spieler wählt
    Console.Write("Schere, Stein oder Papier? ");
    string spieler = Console.ReadLine();

    // Falsche Eingabe prüfen
    if (spieler != "Schere" && spieler != "Stein" && spieler != "Papier")
    {
        Console.WriteLine("Ungültige Eingabe");
    }
    else
    {
        // Computer wählt zufällig
        int zahl = zufall.Next(1, 4);
        string computer = "";

        if (zahl == 1)
        {
            computer = "Schere";
        }
        if (zahl == 2)
        {
            computer = "Stein";
        }
        if (zahl == 3)
        {
            computer = "Papier";
        }

        Console.WriteLine("Computer: " + computer);

        // Gewinner bestimmen
        if (spieler == computer)
        {
            Console.WriteLine("Unentschieden!");
        }
        else if (spieler == "Schere" && computer == "Papier")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else if (spieler == "Stein" && computer == "Schere")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else if (spieler == "Papier" && computer == "Stein")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else
        {
            Console.WriteLine("Der Computer gewinnt!");
            punkteComputer = punkteComputer + 1;
        }

        // Punktestand anzeigen
        Console.WriteLine("Punkte: Du " + punkteSpieler + " - Computer " + punkteComputer);
    }

    // Nochmals spielen?
    Console.Write("Nochmals spielen (j/n)? ");
    nochmal = Console.ReadLine();
}

// Gesamtsieger anzeigen
if (punkteSpieler > punkteComputer)
{
    Console.WriteLine("Du hast gewonnen!");
}
else if (punkteComputer > punkteSpieler)
{
    Console.WriteLine("Der Computer hat gewonnen!");
}
else
{
    Console.WriteLine("Unentschieden!");
}

Console.ReadLine();