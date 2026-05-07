---
title: Architettura del progetto demo
order: 1
---

# 🏗️ Architettura

Questo file mostra come MdExplorer renderizza un diagramma **PlantUML embedded** in markdown.

## Vista d'insieme

```plantuml
@startuml
!theme cerulean

actor Utente
component "MdExplorer\n(Angular client)" as Client
component "Backend\n(.NET 8)" as Backend
database "SQLite\n(UserDB + EngineDB)" as DB
cloud "Git Remote\n(github / gitlab / ...)" as Git

Utente --> Client : naviga / edita
Client --> Backend : SignalR + REST
Backend --> DB : query / commit
Backend --> Git : clone / pull / push
Backend --> Client : eventi push (file changed, ...)

@enduml
```

> Il diagramma sopra è **renderizzato live** da MdExplorer. Per modificarlo, cliccaci sopra: si apre l'editor PlantUML, salvi e il render si aggiorna istantaneamente.

## Flow di un'apertura progetto

```plantuml
@startuml
:Utente clicca su un progetto;
:Backend disabilita FileSystemWatcher;
:Crea/aggiorna record Project in UserDB;
:ProjectsManager.SetNewProject() inizializza struttura;
:Riabilita FileSystemWatcher;
:Frontend naviga a /main/navigation/document;
:GET /api/mdfiles/GetShallowStructure;
:Indicizza file .md in EngineDB;
fork
  :IndexLinksInBackground();
  :Parse PlantUML / link;
fork again
  :Parse YAML front-matter;
end fork
@enduml
```

## Riferimenti

- [Feature MDE-specifiche](features.md) — l'altra metà di `docs/`
- [README del progetto demo](../README.md) — torna alla home
- [Sintassi markdown](../02-markdown-basics.md) — sintassi base

---

*Vedi anche: PlantUML è renderizzato per-block in modo isolato (vedi commit `51d7583b` di MDE) per evitare che un errore in un diagramma blocchi gli altri.*
