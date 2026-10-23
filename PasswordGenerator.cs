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
            while (zeichen == "")
            {
                Console.Write("Kleinbuchstaben verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "abcdefghijklmnopqrstuvwxyz";
                }

                Console.Write("Grossbuchstaben verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                }

                Console.Write("Zahlen verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "0123456789";
                }

                Console.Write("Sonderzeichen verwenden (j/n)? ");
                if (Console.ReadLine() == "j")
                {
                    zeichen = zeichen + "!@#$%&*?";
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

            Console.ReadLine();
        }
    }
}