---
title: Workflow di ingest di una nuova source
kind: diagram
diagram_type: activity
last_updated: 2026-05-10
---

# 🔄 Workflow: ingest di una nuova source

Cosa succede quando l'umano aggiunge un documento grezzo al wiki: l'agente AI legge, riassume, propaga, e logga — il tutto sotto il controllo dell'umano (che approva o richiede modifiche).

```plantuml
@startuml
skinparam backgroundColor #f7fafc
skinparam shadowing false
skinparam roundCorner 12
skinparam DefaultFontName Helvetica
skinparam DefaultFontColor #1a202c

skinparam activityBackgroundColor #ffffff
skinparam activityBorderColor #667eea
skinparam activityFontColor #1a202c
skinparam activityBorderThickness 1.5
skinparam activityStartColor #5568d3
skinparam activityEndColor #5568d3
skinparam activityBarColor #5568d3
skinparam activityDiamondBackgroundColor #f093fb
skinparam activityDiamondBorderColor #764ba2
skinparam activityDiamondFontColor #1a202c

skinparam ArrowColor #5568d3
skinparam ArrowFontColor #4a5568

skinparam partitionBackgroundColor #f7fafc
skinparam partitionBorderColor #cbd5e0
skinparam partitionFontColor #4a5568

skinparam noteBackgroundColor #fef3c7
skinparam noteBorderColor #d69e2e
skinparam noteFontColor #1a202c

|👤 Umano|
start
:Aggiunge un file in sources/raw/\n(PDF, transcript, articolo);

|🤖 Agente AI|
:Legge la fonte\n(intero documento);

:Estrae claim chiave\ncon riferimenti puntuali;

:Scrive sources/YYYY-MM-titolo.md\n(riassunto 3-5 paragrafi);

note right
  Niente sintesi creative:
  solo claim verificabili
  con citazione alla source.
end note

:Identifica entita menzionate\n(nuove o esistenti);

if (entita esiste gia?) then (si)
  :Aggiorna entities/nome.md\n(append Punti chiave\n+ Storico);
else (no)
  :Crea entities/nome.md\nseguendo il template;
endif

:Identifica concetti menzionati;

if (concetto esiste gia?) then (si)
  if (la nuova fonte\ncontraddice quella vecchia?) then (si)
    #f093fb:Segnala CONTRADDIZIONE\nnon sovrascrive;
    :Logga CONFLICT in log.md;
  else (no)
    :Aggiorna concepts/nome.md;
  endif
else (no)
  :Crea concepts/nome.md;
endif

:Aggiorna index.md\n(aggiunge le nuove pagine\nsotto la categoria giusta);

:Append in log.md:\nINGEST sources/id\n-> touched: lista file;

|👤 Umano|
:Esamina il diff sintetico\ndelle pagine toccate;

if (modifiche OK?) then (si)
  :Commit in Git\n(git commit -m ingest titolo);
  stop
else (no)
  #f093fb:Richiede modifiche all'agente;
  detach
endif

@enduml
```

## Note operative

- **Niente decisioni unilaterali**: il diff viene sempre mostrato all'umano prima del commit
- **Contraddizioni mai sovrascritte**: vengono segnalate esplicitamente come marker visibile (`> ⚠️ Contraddizione...`) e loggate
- **Touched list**: il log riporta esattamente quali file sono cambiati, per poter riprodurre/auditare
- **Ingestion batch**: per progetti grandi si può ingerire più sources in un colpo, ma con minor controllo umano

## Vedi anche

- [Use case](use-case.md) — vista d'insieme degli attori
- [Sequence di query](sequence-query.md) — l'altro flusso principale
- [CLAUDE.md](../CLAUDE.md) — le regole che l'agente segue
