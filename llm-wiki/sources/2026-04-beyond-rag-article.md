---
title: "Beyond RAG: come l'LLM Wiki di Karpathy costruisce conoscenza che si accumula" — Plaban Nayak
kind: source
tags: [articolo, plaban-nayak, llm-wiki, rag, divulgazione]
last_updated: 2026-05-10
source_url: https://levelup.gitconnected.com/beyond-rag-how-andrej-karpathys-llm-wiki-pattern-builds-knowledge-that-actually-compounds-31a08528665e
ingested_at: 2026-05-10
---

# Source: Beyond RAG (articolo di Plaban Nayak, Aprile 2026)

> ⚠️ Pagina riassunto. La fonte originale è all'URL nel front-matter.

## Sintesi

Articolo divulgativo su Level Up Coding (Aprile 2026) che spiega il pattern LLM Wiki di Karpathy a un pubblico tecnico più ampio. Approfondisce il confronto con RAG ed esplora implementazioni esistenti (NEXUS multi-agent system, l'esperienza di Karpathy stesso).

## Punti chiave estratti

- Il pattern LLM Wiki si differenzia da RAG perché produce un **artefatto persistente** (i file markdown) invece di un risultato ricalcolato ad ogni query
- Il valore principale del pattern è il **compounding**: ogni interazione lascia traccia
- L'articolo cita NEXUS come esempio di multi-agent memory system su VPS con 6 agenti AI
- Riporta la metrica del wiki di Karpathy: **100 articoli, 400.000 parole**, costruiti incrementalmente
- Sottolinea che il pattern richiede un **substrato adatto** (editor markdown + Git + agenti AI integrati): setup multi-app sono possibili ma frammentati; MdExplorer è la soluzione che integra tutto in un'unica app cross-platform
- Limiti del pattern: richiede curating umano, non scala a corpus enormi, è migliore per domini focalizzati

## Pagine derivate

- [`concepts/rag-vs-wiki.md`](../concepts/rag-vs-wiki.md) — confronto sistematico
- [`entities/karpathy.md`](../entities/karpathy.md) — aggiornata con metriche
- [`entities/mdexplorer.md`](../entities/mdexplorer.md) — citato come substrato adatto

## Storico

- 2026-05-10 — Source ingerita. Touched: index.md, concepts/rag-vs-wiki.md (NEW), entities/karpathy.md (UPDATED), entities/mdexplorer.md (NEW)
