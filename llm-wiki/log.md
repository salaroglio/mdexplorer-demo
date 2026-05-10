---
title: Log delle operazioni
kind: log
last_updated: 2026-05-10
---

# 📜 Log delle operazioni

Diario **append-only** di tutto ciò che succede nel wiki. Ogni riga è un evento. Mai modificare righe esistenti — solo appendere.

> Formato: `[YYYY-MM-DD HH:MM] EVENT_TYPE — descrizione`

---

```
[2026-05-10 14:00] WIKI-INIT — Wiki creato. Schema CLAUDE.md v1.0 attivo.
[2026-05-10 14:05] INGEST sources/2026-04-karpathy-gist — Aggiunto riassunto del gist di Karpathy. Touched: index.md, entities/karpathy.md (NEW), concepts/llm-wiki.md (NEW), concepts/knowledge-compounding.md (NEW).
[2026-05-10 14:18] INGEST sources/2026-04-beyond-rag-article — Aggiunto riassunto dell'articolo di Plaban Nayak. Touched: index.md, concepts/rag-vs-wiki.md (NEW).
[2026-05-10 14:25] ENTITY-CREATED entities/mdexplorer.md — Pagina entità per MdExplorer (menzionato in 2 sources, mancava pagina dedicata).
[2026-05-10 14:32] ENTITY-CREATED entities/carlo-salaroglio.md — Pagina entità per il creator di MdExplorer (menzionato in entities/mdexplorer.md).
[2026-05-10 14:40] DIAGRAM-CREATED diagrams/use-case.md — Diagramma use case del pattern LLM Wiki.
[2026-05-10 14:45] DIAGRAM-CREATED diagrams/workflow-ingestion.md — Diagramma activity del flusso di ingest.
[2026-05-10 14:50] DIAGRAM-CREATED diagrams/sequence-query.md — Diagramma sequence del flusso di query.
[2026-05-10 15:00] LINT — Eseguito lint settimanale. 0 link rotti, 0 pagine orfane, 0 contraddizioni. GAP rilevato: manca pagina concept "schema document" (riferito in 4 pagine ma non ha dedicated page). TODO: ingestione mirata.
```

---

## Significato dei tag eventi

| Tag | Significato |
|---|---|
| `WIKI-INIT` | Inizializzazione del wiki o cambio schema major |
| `INGEST` | Aggiunta di una nuova source (riassunto + propagazione su entità/concetti) |
| `ENTITY-CREATED` | Nuova pagina entità creata (es. trovata menzione ricorrente) |
| `CONCEPT-CREATED` | Nuova pagina concept creata (es. da risposta a una query) |
| `DIAGRAM-CREATED` | Nuovo diagramma PlantUML |
| `QUERY` | Domanda ricevuta dall'umano |
| `QUERY → SAVED` | Risposta a una query salvata come pagina permanente |
| `CONFLICT` | Contraddizione rilevata tra fonti — richiede attenzione umana |
| `GAP` | Lacuna di conoscenza identificata — area dove servirebbero più fonti |
| `LINT` | Esecuzione del lint periodico (settimanale) |
| `SCHEMA-UPDATE` | Modifica del file `CLAUDE.md` — il contratto è cambiato |

---

*Questo file è un'append-only log. Non riordinare, non rinumerare, non riformulare. Le righe sono in ordine cronologico stretto.*
