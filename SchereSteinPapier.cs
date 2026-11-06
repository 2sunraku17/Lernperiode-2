Random zufall = new Random();
int punkteSpieler = 0;
int punkteComputer = 0;
string nochmal = "j";

while (nochmal == "j")
{
    Console.Write("Schere, Stein oder Papier? ");
    string spieler = Console.ReadLine().ToLower();

    if (spieler != "schere" && spieler != "stein" && spieler != "papier")
    {
        Console.WriteLine("Ungültige Eingabe");
    }
    else
    {
        int zahl = zufall.Next(1, 4);
        string computer = "";

        if (zahl == 1)
        {
            computer = "schere";
        }
        if (zahl == 2)
        {
            computer = "stein";
        }
        if (zahl == 3)
        {
            computer = "papier";
        }

        Console.WriteLine("Computer: " + computer);

        if (spieler == computer)
        {
            Console.WriteLine("Unentschieden!");
        }
        else if (spieler == "schere" && computer == "papier")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else if (spieler == "stein" && computer == "schere")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else if (spieler == "papier" && computer == "stein")
        {
            Console.WriteLine("Du gewinnst!");
            punkteSpieler = punkteSpieler + 1;
        }
        else
        {
            Console.WriteLine("Der Computer gewinnt!");
            punkteComputer = punkteComputer + 1;
        }

        Console.WriteLine("Punkte: Du " + punkteSpieler + " - Computer " + punkteComputer);
    }

    Console.Write("Nochmals spielen (j/n)? ");
    nochmal = Console.ReadLine().ToLower();
}

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
