---
title: MdExplorer
document_type: slides
reveal:
  theme: white
  config:
    width: 1280
    height: 720
    slideNumber: c/t
    transition: fade
    pdfSeparateFragments: false
---

<img src="assets/mdexplorer.png" alt="MdExplorer" width="170">

# MdExplorer

Dove persone e agenti AI lavorano sugli stessi documenti

Note:
Aprire dicendo che questa presentazione è un file markdown, aperto dentro MdExplorer.
Tutto quello che si vedrà nell'ora è dentro questo progetto demo: nessun materiale esterno.

---

## Perché l'AI in azienda si ferma

- La conoscenza sta in Word, nelle wiki e nelle teste: **l'AI non la legge** <!-- .element: class="fragment" -->
- Gli strumenti più capaci vivono nel terminale: **li usa solo chi programma** <!-- .element: class="fragment" -->
- Ognuno usa l'AI a modo suo: **nessuna regola comune, nessuna verifica** <!-- .element: class="fragment" -->

Note:
Chiedere se si riconosce in almeno uno dei tre punti. Sono i tre ostacoli a cui rispondono le tre parti
della presentazione.

---

## L'idea

```plantuml
@startuml
!theme plain
scale 1.8
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam ActorBorderColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centro>> #E8F0FE
  BorderColor<<Centro>> #1A73E8
}
hide stereotype

actor "Persone" as P
rectangle "MdExplorer" {
  rectangle "Documenti in markdown\ndentro git" as D <<Centro>>
}
rectangle "Agenti AI" as A

P --> D : leggono, correggono, presentano
A --> D : leggono, scrivono, verificano
@enduml
```

Un solo formato, un solo posto, una sola cronologia.

Note:
Il markdown è il formato che i modelli leggono e scrivono meglio. Git è la cronologia.
MdExplorer rende le due cose comode per chi non programma e governabili per chi decide.

---

## Tre cose da ricordare

1. **Documenti vivi**: la conoscenza è leggibile dalle persone e dall'AI
2. **MarkAgent**: l'AI lavora dentro il progetto, con regole comuni
3. **Controllo**: ogni modifica si vede, e ciò che conta si verifica

---

<!-- .slide: data-background-color="#1b2a3a" -->

## 1 · Documenti vivi

La conoscenza in un formato che leggono tutti

---

## Un documento che fa da solo

- I diagrammi rispondono al clic
- I file veri si includono, non si copiano
- Il testo si corregge nel punto in cui si legge
- Gli esempi si eseguono dalla pagina

[Prova: i documenti vivi](../tour/01-documenti-vivi.md) · [Un documento vero: l'architettura](../caso-studio/02-architettura.md)

Note:
Aprire l'architettura del caso di studio. Cliccare una classe del diagramma, mostrare il diagramma
disegnato dal file JSON, il prototipo HTML. Tornare qui con la freccia indietro della barra.

---

## Un diagramma che si interroga

```plantuml
@startuml
!theme plain
scale 1.8
left to right direction
hide empty members
skinparam classAttributeIconSize 0
skinparam ClassBackgroundColor #F1F3F4
skinparam ClassBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam NoteBackgroundColor #FEF7E0
skinparam NoteBorderColor #F29900

class Ticket
class Bozza
class Valutazione
abstract class Fonte
class ArticoloKB
class Operatore

Ticket "1" *-- "0..1" Bozza : ha >
Bozza "1" *-- "0..1" Valutazione : riceve >
Bozza "0..*" o-- "1..*" Fonte : cita >
Fonte <|-- ArticoloKB
Valutazione ..> Operatore : scritta da
note bottom of Bozza : Mai inviata senza approvazione
@enduml
```

Un clic su una classe accende le sue relazioni, con un colore per tipo.

Note:
Cliccare Bozza. Poi il pulsante con l'occhio per vederlo a tutta pagina.

---

## Da un markdown a tutto il resto

<div class="r-hstack" style="gap:40px; align-items:flex-start">
<div style="flex:1">

**Lo stesso file diventa**

- una presentazione, come questa
- un documento Word
- un PDF o un sito da inviare

</div>
<div style="flex:1">

**Senza cambiare strumento**

- si corregge dalla slide
- si annota mentre si presenta
- resta tutto in git

</div>
</div>

[Prova: le presentazioni](../tour/04-presentazioni.md) · [Prova: Word, PDF e sito](../tour/05-word-pdf-sito.md)

Note:
Qui correggere dal vivo una parola di questa slide con «Modifica», poi annotare con la penna.

---

<!-- .slide: data-background-color="#1b2a3a" -->

## 2 · MarkAgent

L'AI dentro il progetto, con regole comuni

---

## L'AI lavora dove sta la conoscenza

- Legge e scrive i documenti del progetto
- Spiega un diagramma, risponde su un punto di una slide
- Scrive documenti, diagrammi, slide e test con le convenzioni di casa
- Una sola conversazione per tutte le funzioni

[Prova: MarkAgent](../tour/03-markagent.md) · [Il caso di studio](../caso-studio/README.md)

Note:
Dimostrazione principale. Nel caso di studio ci sono tre incongruenze volute fra requisiti, architettura e
verbale: chiedere a MarkAgent di trovarle. Poi chiedere di aggiungere una slide alla presentazione del comitato.

---

## Un motore solo, a scelta dell'azienda

```plantuml
@startuml
!theme plain
scale 1.8
left to right direction
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Centro>> #E8F0FE
  BorderColor<<Centro>> #1A73E8
}
hide stereotype

rectangle "MarkAgent\ne tutte le funzioni AI" as M <<Centro>>
rectangle "Claude Code" as C
rectangle "GitHub Copilot" as G
rectangle "opencode" as O

M --> C
M --> G
M --> O
@enduml
```

Si sceglie per progetto. Cambiare fornitore non cambia il modo di lavorare.

Note:
Il punto per chi governa l'adozione: un solo motore scelto in un solo posto, per tutte le funzioni.
Niente funzioni che di nascosto usano un altro modello.

---

## Le regole viaggiano con il progetto

| Skill | Cosa insegna all'agente |
|---|---|
| mde-doc | come si scrive un documento, con il riassunto in testa |
| mde-plantuml | come si disegna un diagramma leggibile |
| mde-slide | come si scrive una presentazione |
| mde-e2e | come si scrive e si esegue un test di un sito |

MdExplorer le distribuisce in ogni progetto e le tiene aggiornate.

Note:
Le skill sono file di testo nel progetto: si leggono, si correggono, si versionano. Un'azienda può
aggiungere le proprie. È il modo in cui le buone pratiche diventano comportamento dell'agente.

---

## La conoscenza aperta a ogni agente

- Un server MCP espone il progetto agli agenti: cerca nei documenti, verifica i diagrammi
- Collega Jira e Confluence
- Per ogni progetto si accendono solo i gruppi di funzioni che servono

[Prova: regole, skill e MCP](../tour/07-regole-skill-mcp.md)

Note:
MCP è lo standard con cui un agente usa strumenti esterni. Accendere solo i gruppi che servono
riduce il contesto consumato a ogni conversazione.

---

<!-- .slide: data-background-color="#1b2a3a" -->

## 3 · Controllo

Fidarsi dell'AI, e verificare

---

## Ogni modifica si vede

- Tutto ciò che l'AI scrive è una modifica in git: si legge, si accetta, si annulla
- Il messaggio di commit lo propone l'AI, lo approva la persona
- Ogni repository del progetto ha il suo stato, sempre visibile

[Prova: git senza terminale](../tour/06-git.md)

---

## Ciò che conta si verifica

- L'agente verifica i diagrammi che scrive, prima di metterli nel documento
- I test di un sito si scrivono in italiano e l'esito resta scritto nel file
- Ogni test lascia uno script che si rigioca in pochi secondi, senza AI

[Prova: i test scritti in italiano](../tour/08-test-e2e.md)

Note:
Il test end-to-end è l'esempio più chiaro di AI verificabile: l'agente esegue, lascia screenshot,
esito e uno script. Dalla volta dopo lo script gira da solo e non costa niente.

---

## MdExplorer è costruito così

| Dato | Valore |
|---|---|
| Commit da marzo 2021 | 1.311 |
| Commit nel 2026 | 662 |
| di cui firmati insieme a un agente AI | 638 |
| Piani di sprint scritti in MdExplorer | 54 |

[Dietro le quinte](dietro-le-quinte.md)

Note:
Questo è l'argomento più forte per chi si occupa di adozione: il prodotto è la prova del metodo.
Un piano scritto in markdown, un agente che lo esegue, una verifica, un commit.

---

## Aperto e sotto controllo

- Codice aperto, licenza MIT
- I documenti restano sul computer e nel git dell'azienda
- Windows e Linux
- Nessun formato proprietario: sono file markdown

---

## Il prossimo passo

1. Un gruppo, un progetto vero, quattro settimane
2. Le regole di casa scritte come skill
3. Si misura cosa cambia: tempi, qualità, uso

Note:
Adattare questa slide alla richiesta che si vuole fare all'interlocutore.

---

## Grazie

[mdexplorer.net](https://www.mdexplorer.net) · [github.com/salaroglio/MdExplorer](https://github.com/salaroglio/MdExplorer)

Il progetto demo che avete visto si apre da MdExplorer con «Crea progetto demo».
