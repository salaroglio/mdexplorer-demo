---
title: Sequence di una query (domanda → risposta → nuova pagina)
kind: diagram
diagram_type: sequence
last_updated: 2026-05-10
---

# 💬 Sequence: dalla domanda alla nuova pagina

Quando l'umano fa una domanda al wiki, l'LLM non si limita a rispondere — la risposta utile diventa **nuova conoscenza permanente**. Questo è il meccanismo del **knowledge compounding**.

```plantuml
@startuml
skinparam backgroundColor #f7fafc
skinparam shadowing false
skinparam roundCorner 12
skinparam DefaultFontName Helvetica
skinparam DefaultFontColor #1a202c

skinparam sequence {
  ArrowColor #5568d3
  ArrowFontColor #4a5568
  LifeLineBorderColor #5568d3
  LifeLineBackgroundColor #e0e7ff
  ParticipantBackgroundColor #667eea
  ParticipantBorderColor #5568d3
  ParticipantFontColor #ffffff
  ActorBackgroundColor #667eea
  ActorBorderColor #5568d3
  ActorFontColor #ffffff
  GroupBackgroundColor #f7fafc
  GroupBorderColor #764ba2
  GroupFontColor #1a202c
}

skinparam note {
  BackgroundColor #fef3c7
  BorderColor #d69e2e
  FontColor #1a202c
}

actor "👤 Curatore" as H
participant "🛰️ MdExplorer\n(UI + search)" as MDE
participant "🤖 Agente AI" as LLM
participant "📚 Wiki\nfiles" as W
participant "📜 log.md" as L

H -> MDE : "Quali sono le differenze\ntra RAG e LLM Wiki?"
MDE -> LLM : query + accesso file system

== Discovery ==
LLM -> W : leggi **index.md**
W --> LLM : catalogo pagine
note right of LLM
  Identifica **2-5 pagine candidate**
  basate sulle keyword e sull'index.
end note

LLM -> W : leggi **concepts/rag-vs-wiki.md**
W --> LLM : contenuto pagina
LLM -> W : leggi **concepts/llm-wiki.md**
W --> LLM : contenuto pagina
LLM -> W : leggi **concepts/knowledge-compounding.md**
W --> LLM : contenuto pagina

== Sintesi ==
LLM -> LLM : sintetizza\nrisposta con\ncitazioni inline
LLM --> MDE : risposta + citazioni\n[concepts/rag-vs-wiki.md]\n[concepts/llm-wiki.md]
MDE --> H : mostra risposta

== Compounding (opzionale) ==
LLM -> H : "La risposta era non banale.\nVuoi che la salvi come\n**pagina concept**?"

alt risposta utile e riusabile
  H -> LLM : "Sì, salvala"
  LLM -> W : crea **concepts/<nuovo>.md**
  LLM -> W : aggiorna **index.md**
  LLM -> L : append `QUERY → SAVED concepts/<id>`
  W --> H : pagina creata, visibile nell'albero
else risposta one-shot
  H -> LLM : "No, basta così"
  LLM -> L : append `QUERY (no save)`
end

== Gap detection ==
opt risposta incompleta
  LLM -> L : append `GAP: <descrizione>\n— area dove serve nuova source`
  note right of L
    Le GAP guidano la
    cura futura delle
    fonti grezze.
  end note
end

@enduml
```

## Cosa rende speciale questo flusso

1. **Search via index, non via embeddings**: l'LLM legge `index.md` (è il TOC del wiki) e identifica le pagine candidate. Niente vector DB richiesto.
2. **Lettura completa, non chunk**: se una pagina è candidata, l'LLM la legge **per intero** invece di prendere solo i top-k chunk. Questo evita risposte frammentate.
3. **Citazione inline obbligatoria**: ogni claim nella risposta ha `[fonte]` puntuale alla pagina del wiki.
4. **Compounding opt-in**: l'umano decide caso per caso se "promuovere" una risposta a pagina permanente.
5. **Gap come lavoro futuro**: se la risposta è incompleta, viene loggato un `GAP` che guida la prossima ingestione di fonti.

## Vedi anche

- [Use case](use-case.md) — vista d'insieme degli attori
- [Workflow di ingest](workflow-ingestion.md) — l'altro flusso principale
- [Knowledge Compounding](../concepts/knowledge-compounding.md) — il concetto teorico dietro questo flusso
