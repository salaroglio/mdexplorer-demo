---
title: Architecture of the assistant
author: Luca Bianchi
---

# Architecture of the assistant

## TL;DR

The assistant is a service that sits between the ticket system and a language model. It searches the
knowledge base, builds a draft with its sources and shows it to the operator in the operator's panel.
This document describes the parts, the path of a ticket and the data model.

- Four components: operator panel, assistant service, knowledge base, model.
- Below the confidence threshold the assistant **proposes nothing**: it is the red branch of the diagram.
- The text of the ticket is sent to a model **in the cloud**, as it is.

## The components

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
  BackgroundColor<<Subject>> #E8F0FE
  BorderColor<<Subject>> #1A73E8
}
hide stereotype

actor Operator
rectangle "Operator panel" as Panel
rectangle "Ticket system" as Ticket
rectangle "Assistant service" as Assistant <<Subject>>
database "Knowledge base" as KB
cloud "Language model\n(in the cloud)" as Model

Operator --> Panel : reads, approves
Panel --> Ticket : sends the reply
Ticket --> Assistant : new ticket
Assistant --> KB : searches the sources
Assistant --> Model : asks for the draft
Assistant --> Panel : draft with its sources
@enduml
```

In blue, the component to build. In amber, the only part outside the company network.

## The path of a ticket

```plantuml
@startuml
!theme plain
skinparam ParticipantBackgroundColor #F1F3F4
skinparam ParticipantBorderColor #5F6368
skinparam SequenceLifeLineBorderColor #5F6368
skinparam ArrowColor #5F6368
skinparam participant {
  BackgroundColor<<Subject>> #E8F0FE
  BorderColor<<Subject>> #1A73E8
}
hide stereotype

actor Operator
participant "Panel" as P
participant "Assistant service" as S <<Subject>>
database "Knowledge base" as KB
participant "Model" as M

P -> S ++ : new ticket
S -> KB ++ : searches articles and similar tickets
return sources with a score
S -> M ++ : ticket text and sources
return draft and confidence
alt #FCE8E6 confidence below the threshold
  S -[#D93025]> P : no draft, with the reason
else #E6F4EA confidence is enough
  S -> P : draft with the sources cited
end
deactivate S
Operator -> P : approves, edits or discards
P -> S : the operator's rating
@enduml
```

## The data model

When you click a class, MdExplorer lights up its relations with one colour per type.

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
  BackgroundColor<<New>> #E6F4EA
  BorderColor<<New>> #188038
}

class Ticket {
  +number
  +text
  +status
}
class Customer {
  +name
  +contract
}
class Operator {
  +name
  +shift
}
class Draft <<New>> {
  +text
  +confidence
  +model
}
class Rating <<New>> {
  +outcome
  +date
}
abstract class Source {
  +title
  +score
}
class KBArticle
class ClosedTicket

Customer "1" -- "0..*" Ticket : opens >
Ticket "1" *-- "0..1" Draft : has >
Draft "1" *-- "0..1" Rating : receives >
Draft "0..*" o-- "1..*" Source : cites >
Source <|-- KBArticle
Source <|-- ClosedTicket
Rating ..> Operator : written by

note right of Draft : Never sent without approval (R3).\nBelow the threshold it is not created (R4).
note right of Rating : accepted, edited or discarded (R5)
@enduml
```

In green, the classes the pilot adds to the ticket system.

## The configuration, read from the file

The thresholds are not written here: the diagram is drawn from the file the service uses too.

```plantuml(@json, ./data/target-metrics.json)
#highlight "thresholds"
#highlight "stopCriteria"
```

## The operator panel

The prototype of the screen, to open and try:

```html(./mockup/operator-panel.html)
```

## The open choices

| # | Choice | Status |
|---|---|---|
| A1 | Model in the cloud or model hosted in the company | open: depends on R6 |
| A2 | Keyword search or search by meaning in the knowledge base | decided: both |
| A3 | Where to keep the operators' ratings | decided: in the ticket system |

See also the [requirements](01-goals-and-requirements.md) and the [pilot plan](03-pilot-plan.md).
