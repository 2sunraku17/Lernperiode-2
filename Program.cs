Console.WriteLine("Willkommen zum Zahlen Guesser!!");

int random = new Random().Next(1, 101);

Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt.");
int guess;

do
{
    Console.WriteLine("Rate die Zahl:");

    while (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.WriteLine("Eingabe ist nicht gültig geben sie bitte eine neue zahl ein");
    }
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

} while (guess != random);

Console.WriteLine("Du hast die Zahl erraten!");
