# home-codeingStandardsRefactoring-tjunger
## Refactoring Ausarbeitung
### Was ist Refactoring Definition in eigenen Worten?

Beim Refactoring verändert man die Struktur des Codes, die Funktionalität soll dabei jedoch nicht verändert 
werden. Dies wird gemacht um ihn verständlicher für andere Personen zu machen. Nach diesen Prozess sollte er
leichter zu lesen und nachvollziehbar sein. 

### Welche Vorteile/Nachteile birgt Refactoring?

#### Vorteile

- bessere Leistung / Performance (Vermeidung unnötiger Redundanzen, Zeilen etc.)
- gut für Teamarbeiten (für alle leicht zu lesen)
- falls du deinen Code verkaufen möchtest (gute Struktur schadet nie)

#### Nachteile

- unnötige Arbeit da Endprodukt oft das gleiche bleibt
- Durch Refacturing kann das ein Fehler enstehen (Code kapput machen)

### Was sind die Refactoring-Schritte?

- Neue Anordnung von Parametern 
- Entfernung unnötiger Leerzeilen/Magical Strings usw.
- einen Test-Case aufstellen, immer in Unity ausprobieren ob der Code noch funktioniert
  
### Prinzipien von guten Code?

- leicht lesbar
- verständlich für andere Personen
- keine Redundanzen

DRY - Mehrfache Nennungen von Code verhindern, also mit Variablen arbeiten
KISS - Der Code soll so einfach wie möglich gestaltet werden
YAGNI - "Extras", die nicht unbedingt für die Funktion des Programms nötig sind, sollen entfernt werden
Principle of Least Surprise - Die Funktionen sollten so sein, wie man es sich erwartet
SoC - Der Code sollte in klare Abschnitte gegliedert sein
Single Responsibility Principle - Klassen sollten nur für eine Sache zuständig sein und nicht mehrere Funktionen erfüllen

### Was versteht man unter Code Smell?

Code der funktioniert aber schlecht strukturiert ist und stinkt

### 10 Code Smells die Eure Projekt betreffen können, inkl. Beschreibung und Beispiel.


- Kurze Namen: nur Buchstaben, keine richtige Beschreibung.
- Kommentare: Zu viel unnötige Kommentare können stören und sind oft überflüssig.
- Ausgeschlagenes Erbe: Unterklassen erben Methoden und Daten, die sie gar nicht brauchen.
- Nichtsagende Namen: Variablen, Klassen usw. sollten so benannt sein das man die Funktion direkt ablesen kann.
- Doppelter Code: Ein Code kommt zwei mal vor.
- Datenklasse: Klassen mit Feldern und Zugriffsmethoden ohne Funktionalität.
- Datenklumpen: Eine Gruppe von Objekten, welche häufig zusammen vorkommen.
- Unangebrachte Intimität: Zwei Klassen haben zu enge Verflechtungen miteinander.
- Faule Klasse: Eine Klasse leistet zu wenig, um ihre Existenz zu rechtfertigen.
- Middle Man (Vermittler): Eine Klasse delegiert alle Methodenaufrufe an eine andere Klasse.

Beispiele: Finden Sie in meinen Commits :)

# README

## Development Platform

- OS: MacOS 10.14.3
- Unity Version: 2019.1.14f1
- Visual Studio Code Version: 1.33.0
- Scripting Runtime Version: .NET 4.x Equivalent
- API Compatibility Level: .NET 2.0

## Testcase
Play drücken, über drei Hindernisse springen, gegen das vierte laufen, restart.

## Copyright Game

SantaRun by smeerws
