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
- Durch falsches Refacturing kann ein Fehler enstehen (Code kapput machen)

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


1. Magical String – String der mehr als einmal verwendet wird und immer wieder gehardcodet ist. GameObject Tags die verglichen werden sollte man als variable angeben.

Beispiel des Smells:
```c#
    public void Play(){
        SceneManager.LoadScene("MainScene");
    }
```
Richtig:
```c#
public static string mainScene = "MainScene";
    
    public void Play()
    {
        SceneManager.LoadScene(mainScene);
    }
```
  
2. Magical Value – Ein Wert wie z.B.: float oder int der ohne Beschreibung und Kontext verwendet wird. Die Angabe einer Entfernung bei einem Raycast. 

Beispiel des Smells:
```c#
if(transform.position.x < -15f)
    {
        Destroy(gameObject);
}
```
Richtig:
```c#
    private float leftBorder = -15f;

    if(transform.position.x < leftBorder)
    {
        Destroy(gameObject);
}
```
3. Unnötige Methoden: Methoden die im gesamten Code nicht einmal ausgeführt werden, sollten gelöscht werden.

Beispiel des Smells:
```c#
// Start is called before the first frame update
void Start()
{
        
}

// Update is called once per frame
void Update()
{
``` 
4. Unbenutze Namespaces angeben - nicht verwendete Namespaces die trotzdem angegeben sind. z.B: using System.Collections;  

Beispiel des Smells:
```c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
```

5. Fehlende Angabe von Access Modifiern – private sollte immer angegeben werden auch wenn dies nicht vorgeschrieben ist damit es funktioniert. float number; -> private float number;  

Beispiel des Smells:
```c#
string defaultText;
```

Richtig:
```c#
private string defaultText;
```

6. Kommentare: Zu viel unnötige Kommentare können stören und sind oft überflüssig.  

Beispiel des Smells:
```c#
public void SetResult()
{
    // set the result from the SubtractNumbers Method
    result.text = SubstractNumbers().ToString();

    // remove access from inputField
    InputField1.interactable = false;
    // remove access from the second inputField
    InputField2.interactable = false;

    // sub_Numbers is false
    btn_sub_Numbers.interactable = false;
    // reset is true
    btn_reset.interactable = true;
}
```

7. Poor formating: Ein schlecht formatierter Code ist unangenehm zu lesen und nachzuvollziehen, vor allem für andere. Beispiele sind unnötige Leerzeichen oder zu wenig oder zu viele Tabulatorstopps.

Beispiel des Smells:
```c#
        private     void OnTriggerEnter2D(Collider2D collision){
if(collision.gameObject.tag == obstacleTag){
            GameManager.instance.GameOver();


            
        Destroy(collision.gameObject);
            anim.Play(deathAnim);
gameOver = SetGameOverTrue();
}}}
```

Richtig:
```c#
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == obstacleTag)
        {
            GameManager.instance.GameOver();
            Destroy(collision.gameObject);
            anim.Play(deathAnim);
            gameOver = SetGameOverTrue();
        }
    }
}
```

8. Doppelter Code: Ein Code kommt zwei mal vor.  

Beispiel des Smells:
```c#
    public void Exit()
    {
        Application.Quit();
    }
}

    public void Exit()
    {
        Application.Quit();
    }
}
```

9. Falsche Klammern Setzung – Die Klammern werden nicht einheitlich oder unklar gesetzt.

Beispiel des Smells:
```c#
    public void Play()
            {
        SceneManager.LoadScene(mainScene);
    }
```

Richtig:
```c#
    public void Play()
    {
        SceneManager.LoadScene(mainScene);
    }
```

10. Klasse zu lange – Klasse die mehr als 400 Zeilen Code hat. GameManager und MenuManager haben geteilt jeweils weniger als 400 Zeilen Code.    

Beispiel des Smells:
Klasse mit 400 Zeichen (habe keinen CodeAusschnitt wegen Umfang inkludiert)

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
