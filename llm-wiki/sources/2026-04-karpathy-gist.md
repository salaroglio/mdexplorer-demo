---
title: Karpathy gist su LLM Wiki (Aprile 2026)
kind: source
tags: [karpathy, llm-wiki, fonte-primaria]
last_updated: 2026-05-10
source_url: https://gist.github.com/karpathy/442a6bf555914893e9891c11519de94f
ingested_at: 2026-05-10
---

# Source: Karpathy gist su LLM Wiki

> ⚠️ Questa è una **pagina riassunto** — il file originale è immutabile e si trova al link sopra. NON modificare il riassunto in modo che cambi le claim originali; aggiungi solo annotazioni se serve.

## Sintesi

Andrej Karpathy pubblica ad Aprile 2026 un gist GitHub in cui descrive il pattern **LLM Wiki**, un'alternativa a RAG dove un agente AI mantiene attivamente un wiki strutturato di pagine markdown invece di fare retrieval ad ogni query. Il pattern si articola in tre layer (Raw Sources, Wiki, Schema) ed enfatizza il principio del **knowledge compounding**.

## Punti chiave estratti

- Tre layer: **Raw Sources** (immutabili), **Wiki** (LLM-mantenuto), **Schema** (un file di config)
- Il file di schema è tipicamente `CLAUDE.md` — definisce convenzioni, naming, workflow di update, criteri di lint
- File standard del wiki: `index.md` (catalogo), `log.md` (cronologia append-only), pagine entità, pagine concetto, pagine sintesi
- Workflow ingest: LLM legge fonte → riassume → aggiorna 10-15 file rilevanti → logga
- Workflow query: LLM cerca nelle pagine via index → sintetizza con citazioni → la risposta diventa potenzialmente nuova pagina
- Lint periodico: trova contraddizioni, claim stantii, pagine orfane, cross-reference mancanti, gap di dati
- Strumento opzionale `qmd` per BM25/vector search locale quando il wiki cresce
- Frase-icona: *"Obsidian è l'IDE; l'LLM è il programmatore; il wiki è il codebase"*
- Il wiki personale di Karpathy ha raggiunto **100 articoli e 400.000 parole**

## Citabile come

> Karpathy, Andrej. *"LLM Wiki: a persistent, structured knowledge base maintained by AI agents."* GitHub Gist, Aprile 2026. https://gist.github.com/karpathy/442a6bf555914893e9891c11519de94f

## Pagine derivate (entities/concepts toccate da questa source)

- [`entities/karpathy.md`](../entities/karpathy.md) — autore
- [`concepts/llm-wiki.md`](../concepts/llm-wiki.md) — il pattern
- [`concepts/knowledge-compounding.md`](../concepts/knowledge-compounding.md) — il principio
- [`diagrams/use-case.md`](../diagrams/use-case.md) — diagramma derivato
- [`diagrams/workflow-ingestion.md`](../diagrams/workflow-ingestion.md) — diagramma derivato

## Storico

- 2026-05-10 — Source ingerita. Touched: index.md, entities/karpathy.md (NEW), concepts/llm-wiki.md (NEW), concepts/knowledge-compounding.md (NEW)
