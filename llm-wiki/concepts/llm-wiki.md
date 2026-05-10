---
title: LLM Wiki
kind: concept
tags: [knowledge-management, ai-agents, pattern, karpathy]
last_updated: 2026-05-10
---

# LLM Wiki

## Sintesi

**LLM Wiki** è un pattern di knowledge management proposto da [Andrej Karpathy](../entities/karpathy.md) ad Aprile 2026. L'idea centrale: invece di fare retrieval su documenti grezzi ad ogni query (RAG classico), si lascia che un agente AI **costruisca e mantenga attivamente un wiki strutturato in markdown**. Le risposte utili diventano nuove pagine, e la conoscenza **compone** nel tempo.

## Punti chiave

- È un pattern, non un prodotto — implementabile con qualsiasi editor markdown + qualsiasi LLM agent [fonte: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]
- Si basa su **tre layer** chiaramente separati:
  - **Raw Sources** — documenti immutabili curati dall'umano
  - **Wiki** — pagine markdown mantenute dall'LLM
  - **Schema** — file di configurazione (es. `CLAUDE.md`) che governa la struttura
- Il wiki contiene tipicamente: `index.md` (catalogo), `log.md` (cronologia), pagine entità, pagine concetto, pagine sintesi [fonte: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]
- L'LLM si occupa del **bookkeeping**: cross-reference, propagazione di aggiornamenti, segnalazione di contraddizioni
- Il pattern si differenzia da RAG perché il wiki è un **artefatto persistente compoundente**, non un risultato calcolato al volo [fonte: [concepts/rag-vs-wiki](rag-vs-wiki.md)]
- Implementazioni esistenti: Karpathy con Obsidian + Claude Code; NEXUS (sistema multi-agent su VPS); MdExplorer come substrato dedicato [fonte: [sources/2026-04-beyond-rag-article](../sources/2026-04-beyond-rag-article.md)]

## Componenti tipici di un LLM Wiki

| File / cartella | Ruolo |
|---|---|
| `CLAUDE.md` | Schema — regole strutturali, convenzioni di naming, workflow di update |
| `index.md` | Catalogo orientato al contenuto, una riga per pagina |
| `log.md` | Append-only log di ingest, query, lint |
| `sources/` | Riassunti dei documenti grezzi (i raw sotto `sources/raw/`) |
| `entities/` | Pagine per persone, organizzazioni, prodotti |
| `concepts/` | Pagine per idee, pattern, tecniche |

## Workflow chiave

1. **Ingest** — nuova source → LLM riassume → propaga su entità/concetti → logga
2. **Query** — domanda → LLM legge index → legge pagine candidate → sintetizza con citazioni → propone di salvare la risposta come nuova pagina
3. **Lint** — settimanale → trova pagine orfane, link rotti, contraddizioni, gap

## Vedi anche

- [Andrej Karpathy](../entities/karpathy.md) — autore del pattern
- [Knowledge Compounding](knowledge-compounding.md) — l'idea fondante
- [RAG vs Wiki](rag-vs-wiki.md) — il confronto col pattern alternativo
- [MdExplorer](../entities/mdexplorer.md) — un substrato adatto
- [Diagramma use case](../diagrams/use-case.md) — chi fa cosa
- [Diagramma workflow ingest](../diagrams/workflow-ingestion.md) — il flusso

## Storico

- 2026-05-10 — pagina creata da ingest di `sources/2026-04-karpathy-gist`
