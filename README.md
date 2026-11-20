# Lernperiode-2

# Grob-Planung

Wo stehen Sie mit Ihren Noten? In welchen Modulen waren Sie besonders stark; in welchen sind die ungenügend? Welche davon sind besonders wichtig?
Was wäre ein geeignetes Projekt für diese LP1?

# 16.10.2026
- [x] Ein zufälliges Zahlenratespiel entwickeln, das einem mit den Hinweisen „höher“ und „tiefer“ beim Erraten der Zahl hilft.
- [x] Auf Empfehlung des Lehrers habe ich eine Überprüfung für ungültige Eingaben programmiert. Wenn man etwas anderes als eine Zahl zwischen 1 und 100 eingibt, erscheint die Meldung „Ungültige Eingabe“.

✍️Heute habe ich mit der Startaufgabe des Lehrers angefangen, nämlich ein Zahlenratespiel zu programmieren. Er hat mir empfohlen, ungültige Eingaben auszusortieren und dem Benutzer eine Nachricht anzuzeigen, dass er eine falsche Eingabe gemacht hat, die nicht zur Fragestellung passt.
- [x] Levels hinzufügen man kann entscheiden Lvl.1 = 1 bis 100,  Lvl.2 = 1-1000,  Lvl.3 = 1 bis 100'000



# 23.10.2026
- [x] Den Benutzer nach der gewünschten Passwortlänge fragen und die Eingabe im Programm verarbeiten. Anschliessend soll die eingegebene Länge zur Kontrolle im Terminal ausgegeben werden.
- [x] Einen Passwort-Generator entwickeln, der mithilfe von Zufallszahlen Kleinbuchstaben und Zahlen auswählt und zu einem Passwort kombiniert. Die Länge des generierten Passworts soll der eingegebenen Länge entsprechen.
- [x] Den Passwort-Generator um Grossbuchstaben und Sonderzeichen erweitern, damit abwechslungsreichere Passwörter erstellt werden können. Der Benutzer soll auswählen können, welche Zeichentypen im Passwort vorkommen dürfen.
- [x] Eine Überprüfung für ungültige Eingaben programmieren, damit beispielsweise falsche Passwortlängen erkannt und mit einer Fehlermeldung beantwortet werden. Zusätzlich soll der Benutzer bestimmen können, wie viele Passwörter generiert und anschliessend im Terminal angezeigt werden.


# 30.10.2026

- [x] HA: Eine Passwort-Bewertung programmieren: Am Schluss wird der Benutzer gefragt, ob er das Passwort bewerten lassen möchte. Wenn er „j“ eingibt, bekommt das Passwort eine Bewertung von 1 bis 10. Die Bewertung hängt davon ab, wie viele Zeichentypen ausgewählt wurden (Kleinbuchstaben, Grossbuchstaben, Zahlen, Sonderzeichen) und wie lang das Passwort ist. Je länger das Passwort und je mehr Zeichentypen, desto besser die Bewertung.



- [x] Ein Schere-Stein-Papier-Spiel programmieren, bei dem der Benutzer etwas eingibt und der Computer zufällig auswählt.
- [x] Die Gewinnregeln programmieren und ungültige Eingaben mit einer Fehlermeldung abfangen.
- [x] Mehrere Runden ermöglichen und einen Punktestand für Benutzer und Computer mitzählen.
- [x] Am Schluss den Gesamtsieger anzeigen und fragen, ob man nochmals spielen möchte (j/n).

- Heute habe ich ein Schere Stein Papier Game programmiert was eine Zufallsoption nimmt nachdem ich meine gesagt habe (Schere, Stein oder Papier). Ich habe diese Idee umgesetzt, da ich es liebe spassige Projekte zu machen und ich eh mit "random" arbeiten wollte weil ich Schwierigkeiten letztes mal hatte.

# 06.11.2026

- [x] HA: Mit ToLower() die Eingabe in Kleinbuchstaben umwandeln, damit das Programm „Papier“ und „papier“ beide erkennt.


- [x] Ein Kampfspiel im Terminal programmieren, bei dem per Zufall ein Monster erscheint: Goblin (50 %), Shrek (35 %) oder Drache (15 %). Jedes Monster hat eigene Lebenspunkte und eigenen Schaden.
  
- [x] Den Kampf programmieren: Der Benutzer greift an, das Monster greift zurück, und nach jeder Runde werden die Lebenspunkte angezeigt.

- [x] Mehrere Aktionen einbauen: Angreifen, Heilen (max. 3x) und Spezialangriff (max. 1x). Ungültige Eingaben werden mit einer Fehlermeldung abgefangen.
 
- [x] Nach einem Sieg erscheint ein neues Monster. Am Schluss wird angezeigt, wie viele Monster man besiegt hat, und gefragt, ob man nochmals spielen möchte (j/n).


- Heute habe ich ein Monster-Kampfspiel im Terminal programmiert, bei dem zufällig ein Goblin, Shrek oder Drache erscheint und man mit Angreifen, Heilen und einem Spezialangriff gegen die Monster kämpft.


# 13.11.2026

- [x] Am Anfang den Spielernamen abfragen und ihn im Spiel verwenden, zum Beispiel „Muris greift an und macht 15 Schaden!“ und bei der Lebenspunkte-Anzeige.

- [x] Farben einbauen mit Console.ForegroundColor: Schaden wird rot angezeigt, Heilung grün und Fehlermeldungen gelb.

- [x] Ein neues Monster hinzufügen (z. B. Skelett) mit eigenen Lebenspunkten und eigenem Schaden. Die Wahrscheinlichkeiten werden so angepasst, dass sie zusammen 100 % ergeben.

- [x] Am Anfang einen Schwierigkeitsgrad auswählen lassen (1 = leicht, 2 = schwer): Bei leicht startet der Spieler mit 150 Lebenspunkten, bei schwer mit 70. Ungültige Eingaben werden mit einer Fehlermeldung abgefangen.


- Heute habe ich mein Monsterspiel erweitert: Am Anfang gibt man jetzt seinen Namen ein und wählt einen Schwierigkeitsgrad. Ausserdem gibt es mit dem Skelett ein neues Monster, und Schaden, Heilung und Fehler werden in verschiedenen Farben angezeigt. Dabei habe ich gemerkt, dass mein Visual-Studio-Projekt nicht mit GitHub verbunden ist. Das will ich als Hausaufgabe lösen.

# 20.11.2026

- [x] HA: Mein GitHub-Repo „Lernperiode-2“ in Visual Studio klonen, das Monsterspiel als Projektordner hinzufügen und mit „Commit und Push“ hochladen, damit Änderungen direkt aus Visual Studio auf GitHub kommen.
Antwort: Code vom Monsterspiel: https://github.com/2sunraku17/Spiel. Aus diesem Grund habe ich die Spiel-.cs Dateien gelöscht oder werde sie noch löschen, denn das ganze Projekt mit Aktualisierungen befindet sich in 2sunraku17/Spiel

- [ ] Kritische Treffer einbauen: Jeder Angriff hat eine Chance von 5 %, doppelten Schaden zu machen. Dann erscheint in Rot die Meldung „Kritischer Treffer!“.

- [ ] Ausweichen einbauen: Der Spieler hat eine Chance von 15 %, einem Monsterangriff auszuweichen. Dann bekommt er keinen Schaden, und es erscheint die Meldung „Du bist ausgewichen!“.

- [ ] Ein Upgrade-System einbauen: Nach jeweils 2 besiegten Monstern kann der Spieler eins von drei Upgrades wählen: +10 % Crit-Chance, +20 maximale Lebenspunkte oder +5 Schaden. Ungültige Eingaben werden mit einer Fehlermeldung abgefangen.

- [ ] Am Spielende eine Statistik anzeigen: wie viele Runden gespielt wurden, wie viel Schaden man insgesamt gemacht hat und wie oft man sich geheilt hat.
