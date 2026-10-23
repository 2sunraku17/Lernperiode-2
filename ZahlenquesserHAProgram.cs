Console.WriteLine("Willkommen zum Zahlen Guesser!!");

Console.WriteLine("Wähle ein Level:");
Console.WriteLine("1 = 1 bis 100");
Console.WriteLine("2 = 1 bis 1000");
Console.WriteLine("3 = 1 bis 100000");

int level = 0;

while (level < 1 || level > 3)
{
    try
    {
        level = Convert.ToInt32(Console.ReadLine());

        if (level < 1 || level > 3)
        {
            Console.WriteLine("Bitte nur 1, 2 oder 3 eingeben!");
        }
    }
    catch
    {
        Console.WriteLine("Falsche Eingabe! Bitte eine Zahl eingeben.");
    }
}

int max;
if (level == 1)
{
    max = 100;
}
else if (level == 2)
{
    max = 1000;
}
else
{
    max = 100000;
}

int random = new Random().Next(1, max + 1);

Console.WriteLine("Ich habe eine Zahl zwischen 1 und " + max + " gewählt.");
int guess = 0;

do
{
    Console.WriteLine("Rate die Zahl:");

    try
    {
        guess = Convert.ToInt32(Console.ReadLine());

        if (guess == random)
        {
            Console.WriteLine("Richtig!");
        }
        else if (guess < random)
        {
            Console.WriteLine("Höher!");
        }
        else
        {
            Console.WriteLine("Tiefer!");
        }
    }
    catch
    {
        Console.WriteLine("Falsche Eingabe! Bitte eine Zahl eingeben.");
    }

} while (guess != random);

Console.WriteLine("Du hast die Zahl erraten!");