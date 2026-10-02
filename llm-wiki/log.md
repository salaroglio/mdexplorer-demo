---
title: Operations log
kind: log
last_updated: 2026-05-10
---

# 📜 Operations log

**Append-only** journal of everything that happens in the wiki. Each line is one event. Never change existing lines — only append.

> Format: `[YYYY-MM-DD HH:MM] EVENT_TYPE — description`

---

```
[2026-05-10 14:00] WIKI-INIT — Wiki created. Schema CLAUDE.md v1.0 active.
[2026-05-10 14:05] INGEST sources/2026-04-karpathy-gist — Added the summary of Karpathy's gist. Touched: index.md, entities/karpathy.md (NEW), concepts/llm-wiki.md (NEW), concepts/knowledge-compounding.md (NEW).
[2026-05-10 14:18] INGEST sources/2026-04-beyond-rag-article — Added the summary of Plaban Nayak's article. Touched: index.md, concepts/rag-vs-wiki.md (NEW).
[2026-05-10 14:25] ENTITY-CREATED entities/mdexplorer.md — Entity page for MdExplorer (mentioned in 2 sources, had no dedicated page).
[2026-05-10 14:32] ENTITY-CREATED entities/carlo-salaroglio.md — Entity page for the creator of MdExplorer (mentioned in entities/mdexplorer.md).
[2026-05-10 14:40] DIAGRAM-CREATED diagrams/use-case.md — Use case diagram of the LLM Wiki pattern.
[2026-05-10 14:45] DIAGRAM-CREATED diagrams/workflow-ingestion.md — Activity diagram of the ingest flow.
[2026-05-10 14:50] DIAGRAM-CREATED diagrams/sequence-query.md — Sequence diagram of the query flow.
[2026-05-10 15:00] LINT — Weekly lint run. 0 broken links, 0 orphan pages, 0 contradictions. GAP found: the concept page "schema document" is missing (referenced in 4 pages but has no dedicated page). TODO: targeted ingest.
```

---

## Meaning of the event tags

| Tag | Meaning |
|---|---|
| `WIKI-INIT` | Initialization of the wiki or major schema change |
| `INGEST` | A new source was added (summary + propagation to entities/concepts) |
| `ENTITY-CREATED` | New entity page created (e.g. a recurring mention was found) |
| `CONCEPT-CREATED` | New concept page created (e.g. from the answer to a query) |
| `DIAGRAM-CREATED` | New PlantUML diagram |
| `QUERY` | Question received from the human |
| `QUERY → SAVED` | Answer to a query saved as a permanent page |
| `CONFLICT` | Contradiction found between sources — needs human attention |
| `GAP` | Knowledge gap identified — an area where more sources would be needed |
| `LINT` | Run of the periodic (weekly) lint |
| `SCHEMA-UPDATE` | Change to the `CLAUDE.md` file — the contract has changed |

---

*This file is an append-only log. Do not reorder, do not renumber, do not reword. The lines are in strict chronological order.*
