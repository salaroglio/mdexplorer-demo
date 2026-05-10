---
title: RAG vs LLM Wiki
kind: concept
tags: [knowledge-management, confronto, rag]
last_updated: 2026-05-10
---

# RAG vs LLM Wiki

## Sintesi

**RAG** (Retrieval-Augmented Generation) e **LLM Wiki** sono due approcci alternativi per dare ad un LLM accesso a conoscenza specifica di dominio. RAG fa retrieval su documenti grezzi ad ogni query; LLM Wiki costruisce un wiki sintetico mantenuto dall'LLM stesso. Le differenze sono profonde nei costi, nella qualità delle risposte, e nella manutenibilità.

## Confronto

| Aspetto | RAG | LLM Wiki |
|---|---|---|
| **Sorgente di conoscenza** | Documenti grezzi (PDF, HTML, transcript) | Wiki markdown sintetico |
| **Storage** | Vector DB (embeddings) | File markdown su disco |
| **Operazione per query** | Embedding + retrieval + reranking + generazione | Lettura `index.md` + lettura 2-5 pagine + sintesi |
| **Knowledge compounding** | ❌ La conoscenza non si accumula | ✅ Ogni risposta utile diventa pagina |
| **Visibilità sulla conoscenza** | ❌ I chunk sono opachi | ✅ Pagine leggibili, diffabili, versionabili |
| **Gestione contraddizioni** | ❌ Nascosta nei chunk | ✅ Segnalata esplicitamente |
| **Costi marginali per query** | Vector search + LLM call | Solo LLM call (search è grep su markdown) |
| **Setup** | Pipeline ingestion + vector DB | Markdown + uno schema CLAUDE.md |
| **Quando usarlo** | Grandi corpus eterogenei, query molto varie | Domini specifici, knowledge stabile, pochi utenti expert |

## I due approcci sono complementari

Il pattern [LLM Wiki](llm-wiki.md) non sostituisce RAG in tutti i casi. Linee guida pratiche:

- **Usa RAG** quando: corpus enorme (>10k documenti), query molto eterogenee, tutti gli utenti hanno esigenze diverse, niente budget per curating umano
- **Usa LLM Wiki** quando: dominio focalizzato, pochi power-user (o uno solo), la qualità della risposta importa più della copertura, vuoi capitalizzare ogni interazione

In alcuni progetti possono coesistere: il wiki cattura le conoscenze stabili curate, RAG copre il long-tail dei documenti grezzi non ancora processati.

## Vedi anche

- [LLM Wiki](llm-wiki.md) — il pattern wiki
- [Knowledge Compounding](knowledge-compounding.md) — il principio del compounding
- [Andrej Karpathy](../entities/karpathy.md) — autore del confronto

## Storico

- 2026-05-10 — pagina creata da ingest di `sources/2026-04-beyond-rag-article`
