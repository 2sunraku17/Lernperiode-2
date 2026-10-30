using System;

namespace PasswortGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random zufall = new Random();

            // 1. Passwortlänge abfragen (mit Prüfung)
            int laenge = 0;
            while (laenge < 4 || laenge > 50)
            {
                Console.Write("Wie lang soll das Passwort sein (4-50)? ");
                string eingabe = Console.ReadLine();

                if (!int.TryParse(eingabe, out laenge))
                {
                    Console.WriteLine("Fehler: Das ist keine Zahl!");
                }
                else if (laenge < 4 || laenge > 50)
                {
                    Console.WriteLine("Fehler: Die Länge muss zwischen 4 und 50 sein!");
                }
            }
            Console.WriteLine("Du hast die Länge " + laenge + " gewählt.");

            // 2. Zeichentypen auswählen
            string zeichen = "";
            int typen = 0; // zählt, wie viele Zeichentypen gewählt wurden
            while (zeichen == "")
            {
                Console.Write("Kleinbuchstaben verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "abcdefghijklmnopqrstuvwxyz";
                    typen = typen + 1;
                }

                Console.Write("Grossbuchstaben verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    typen = typen + 1;
                }

                Console.Write("Zahlen verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "0123456789";
                    typen = typen + 1;
                }

                Console.Write("Sonderzeichen verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "!@#$%&*?";
                    typen = typen + 1;
                }

                if (zeichen == "")
                {
                    Console.WriteLine("Fehler: Du musst mindestens eine Art auswählen!");
                }
            }

            // 3. Anzahl Passwörter abfragen (mit Prüfung)
            int anzahl = 0;
            while (anzahl < 1 || anzahl > 20)
            {
                Console.Write("Wie viele Passwörter willst du (1-20)? ");
                string eingabe = Console.ReadLine();

                if (!int.TryParse(eingabe, out anzahl))
                {
                    Console.WriteLine("Fehler: Das ist keine Zahl!");
                }
                else if (anzahl < 1 || anzahl > 20)
                {
                    Console.WriteLine("Fehler: Die Anzahl muss zwischen 1 und 20 sein!");
                }
            }

            // 4. Passwörter erstellen und ausgeben
            for (int i = 1; i <= anzahl; i++)
            {
                string passwort = "";

                for (int j = 0; j < laenge; j++)
                {
                    int zufallsZahl = zufall.Next(0, zeichen.Length);
                    passwort = passwort + zeichen[zufallsZahl];
                }

                Console.WriteLine("Passwort " + i + ": " + passwort);
            }

            // 5. Passwort bewerten (1 bis 10)
            Console.Write("Passwort bewerten (j/n)? ");
            if (Console.ReadLine() == "j")
            {
                int bewertung = typen; // 1 bis 4 Punkte für die Zeichentypen

                if (laenge >= 8)
                {
                    bewertung = bewertung + 2;
                }
                if (laenge >= 12)
                {
                    bewertung = bewertung + 2;
                }
                if (laenge >= 16)
                {
                    bewertung = bewertung + 2;
                }

                Console.WriteLine("Bewertung: " + bewertung + " von 10");
            }

            Console.ReadLine();
        }
    }
}