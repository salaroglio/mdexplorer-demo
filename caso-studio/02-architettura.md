---
title: Architettura dell'assistente
author: Luca Bianchi
---

# Architettura dell'assistente

## TL;DR

L'assistente è un servizio che sta fra il sistema dei ticket e un modello linguistico. Cerca nella base di
conoscenza, costruisce una bozza con le fonti e la mostra all'operatore nel suo pannello. Questo documento
descrive i pezzi, il percorso di un ticket e il modello dei dati.

- Quattro componenti: pannello dell'operatore, servizio assistente, base di conoscenza, modello.
- Sotto la soglia di fiducia l'assistente **non propone niente**: è il ramo rosso del diagramma.
- Il testo del ticket viene inviato a un modello **in cloud**, così com'è.

## I componenti

```plantuml
@startuml
!theme plain
skinparam RectangleBackgroundColor #F1F3F4
skinparam RectangleBorderColor #5F6368
skinparam DatabaseBackgroundColor #F1F3F4
skinparam DatabaseBorderColor #5F6368
skinparam CloudBackgroundColor #FEF7E0
skinparam CloudBorderColor #F29900
skinparam ArrowColor #5F6368
skinparam rectangle {
  BackgroundColor<<Soggetto>> #E8F0FE
  BorderColor<<Soggetto>> #1A73E8
}
hide stereotype

actor Operatore
rectangle "Pannello dell'operatore" as Pannello
rectangle "Sistema dei ticket" as Ticket
rectangle "Servizio assistente" as Assistente <<Soggetto>>
database "Base di conoscenza" as KB
cloud "Modello linguistico\n(in cloud)" as Modello

Operatore --> Pannello : legge, approva
Pannello --> Ticket : invia la risposta
Ticket --> Assistente : ticket nuovo
Assistente --> KB : cerca le fonti
Assistente --> Modello : chiede la bozza
Assistente --> Pannello : bozza con le fonti
@enduml
```

In blu il componente da costruire. In ambra l'unico pezzo che sta fuori dalla rete aziendale.

## Il percorso di un ticket

```plantuml
@startuml
!theme plain
skinparam ParticipantBackgroundColor #F1F3F4
skinparam ParticipantBorderColor #5F6368
skinparam SequenceLifeLineBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam participant {
  BackgroundColor<<Soggetto>> #E8F0FE
  BorderColor<<Soggetto>> #1A73E8
}
hide stereotype

actor Operatore
participant "Pannello" as P
participant "Servizio assistente" as S <<Soggetto>>
database "Base di conoscenza" as KB
participant "Modello" as M

P -> S ++ : ticket nuovo
S -> KB ++ : cerca articoli e ticket simili
return fonti con punteggio
S -> M ++ : testo del ticket e fonti
return bozza e fiducia
alt #FCE8E6 fiducia sotto la soglia
  S -[#D93025]> P : nessuna bozza, con il motivo
else #E6F4EA fiducia sufficiente
  S -> P : bozza con le fonti citate
end
deactivate S
Operatore -> P : approva, modifica o scarta
P -> S : valutazione dell'operatore
@enduml
```

## Il modello dei dati

Cliccando una classe, MdExplorer accende le sue relazioni con un colore per tipo.

```plantuml
@startuml
!theme plain
hide empty members
skinparam classAttributeIconSize 0
skinparam ClassBackgroundColor #F1F3F4
skinparam ClassBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam NoteBackgroundColor #FEF7E0
skinparam NoteBorderColor #F29900
skinparam class {
  BackgroundColor<<Nuovo>> #E6F4EA
  BorderColor<<Nuovo>> #188038
}

class Ticket {
  +numero
  +testo
  +stato
}
class Cliente {
  +nome
  +contratto
}
class Operatore {
  +nome
  +turno
}
class Bozza <<Nuovo>> {
  +testo
  +fiducia
  +modello
}
class Valutazione <<Nuovo>> {
  +esito
  +data
}
abstract class Fonte {
  +titolo
  +punteggio
}
class ArticoloKB
class TicketChiuso

Cliente "1" -- "0..*" Ticket : apre >
Ticket "1" *-- "0..1" Bozza : ha >
Bozza "1" *-- "0..1" Valutazione : riceve >
Bozza "0..*" o-- "1..*" Fonte : cita >
Fonte <|-- ArticoloKB
Fonte <|-- TicketChiuso
Valutazione ..> Operatore : scritta da

note right of Bozza : Mai inviata senza approvazione (R3).\nSotto la soglia non viene creata (R4).
note right of Valutazione : accettata, modificata o scartata (R5)
@enduml
```

In verde le classi che il pilota aggiunge al sistema dei ticket.

## La configurazione, letta dal file

Le soglie non sono scritte qui: il diagramma è disegnato dal file che usa anche il servizio.

```plantuml(@json, ./dati/metriche-obiettivo.json)
#highlight "soglie"
#highlight "criteriDiArresto"
```

## Il pannello dell'operatore

Il prototipo della schermata, da aprire e provare:

```html(./mockup/pannello-operatore.html)
```

## Le scelte aperte

| # | Scelta | Stato |
|---|---|---|
| A1 | Modello in cloud o modello ospitato in azienda | aperta: dipende da R6 |
| A2 | Ricerca per parole o ricerca per significato nella base di conoscenza | decisa: tutte e due |
| A3 | Dove tenere le valutazioni degli operatori | decisa: nel sistema dei ticket |

Vedi anche i [requisiti](01-obiettivi-e-requisiti.md) e il [piano del pilota](03-piano-del-pilota.md).
