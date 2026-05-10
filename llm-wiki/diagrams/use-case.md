---
title: Use Case del LLM Wiki
kind: diagram
diagram_type: use-case
last_updated: 2026-05-10
---

# 🎭 Use Case: chi fa cosa nel LLM Wiki

Questo diagramma mostra gli **attori** del sistema LLM Wiki (umano curatore, agente AI) e le loro **interazioni principali** col substrato (MdExplorer).

```plantuml
@startuml
skinparam backgroundColor #f7fafc
skinparam shadowing false
skinparam roundCorner 12
skinparam DefaultFontName Helvetica
skinparam DefaultFontColor #1a202c

skinparam actor {
  BackgroundColor #667eea
  BorderColor #5568d3
  FontColor #ffffff
}

skinparam usecase {
  BackgroundColor #ffffff
  BorderColor #667eea
  FontColor #1a202c
  BorderThickness 1.5
}

skinparam rectangle {
  BackgroundColor #ffffff
  BorderColor #764ba2
  FontColor #1a202c
  BorderThickness 2
}

skinparam ArrowColor #5568d3
skinparam ArrowFontColor #4a5568

actor "👤 Curatore\numano" as Human
actor "🤖 Agente\nAI" as LLM

rectangle "**MdExplorer**\n(substrato del wiki)" as MDE {

  usecase "📥 Aggiunge\nuna source\ngrezza" as UC1
  usecase "💬 Pone una\ndomanda al wiki" as UC2
  usecase "✅ Approva\ni cambiamenti\nproposti" as UC3
  usecase "🧹 Lancia\nil lint\nperiodico" as UC4

  usecase "📝 Scrive il\nriassunto della\nsource" as UC5
  usecase "🔄 Aggiorna\nentità e\nconcetti" as UC6
  usecase "🔍 Cerca nelle\npagine via\nindex" as UC7
  usecase "✍️ Sintetizza\nla risposta\ncon citazioni" as UC8
  usecase "📜 Logga le\noperazioni" as UC9
  usecase "🚨 Segnala\ncontraddizioni\ne gap" as UC10
}

Human --> UC1
Human --> UC2
Human --> UC3
Human --> UC4

LLM --> UC5
LLM --> UC6
LLM --> UC7
LLM --> UC8
LLM --> UC9
LLM --> UC10

UC1 ..> UC5 : <<triggers>>
UC1 ..> UC6 : <<triggers>>
UC1 ..> UC9 : <<triggers>>

UC2 ..> UC7 : <<triggers>>
UC2 ..> UC8 : <<triggers>>

UC4 ..> UC10 : <<triggers>>

note right of UC3
  L'umano resta nel loop:
  vede il diff, approva
  o richiede modifiche.
end note

note bottom of LLM
  L'agente segue le regole
  in **CLAUDE.md** (schema).
  Niente decisioni unilaterali.
end note

@enduml
```

## Attori

| Attore | Ruolo | Decisioni |
|---|---|---|
| 👤 **Curatore umano** | Cura le fonti, fa domande, approva i cambiamenti | Cosa includere, cosa escludere, priorità |
| 🤖 **Agente AI** (LLM) | Mantiene il wiki: scrive, aggiorna, sintetizza, segnala | Come strutturare seguendo lo schema |

## Vedi anche

- [Workflow di ingest](workflow-ingestion.md) — l'attività dietro UC1+UC5+UC6
- [Sequence di query](sequence-query.md) — l'attività dietro UC2+UC7+UC8
- [Concept LLM Wiki](../concepts/llm-wiki.md) — il pattern generale
