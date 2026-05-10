---
title: Indice del wiki
kind: index
last_updated: 2026-05-10
---

# 📚 Indice del wiki

Catalogo orientato al contenuto. Una riga per pagina, raggruppato per categoria.

> Questo file viene aggiornato dall'LLM ad ogni ingest e ad ogni nuova pagina concept salvata. Vedi le regole in [`CLAUDE.md`](CLAUDE.md).

## 👥 Entità

- [Andrej Karpathy](entities/karpathy.md) — ricercatore AI, autore del pattern LLM Wiki (Aprile 2026)
- [MdExplorer](entities/mdexplorer.md) — editor markdown professionale con AI integrata, supporta nativamente il pattern LLM Wiki
- [Carlo Salaroglio](entities/carlo-salaroglio.md) — creatore e mantainer di MdExplorer

## 🧠 Concetti

- [LLM Wiki](concepts/llm-wiki.md) — pattern di knowledge management dove un LLM mantiene un wiki strutturato in markdown
- [Knowledge Compounding](concepts/knowledge-compounding.md) — l'idea che la conoscenza utile debba accumularsi nel tempo invece di essere ri-derivata ad ogni query
- [RAG vs Wiki](concepts/rag-vs-wiki.md) — differenze tra retrieval-augmented generation e LLM wiki maintenance

## 📥 Sources

- [2026-04 — Karpathy gist su LLM Wiki](sources/2026-04-karpathy-gist.md) — il documento originale che ha lanciato il pattern
- [2026-04 — Articolo Beyond RAG](sources/2026-04-beyond-rag-article.md) — articolo divulgativo sul pattern, by Plaban Nayak

## 📊 Diagrammi

- [Use case del LLM Wiki](diagrams/use-case.md) — chi fa cosa nel sistema
- [Workflow di ingest](diagrams/workflow-ingestion.md) — flusso di un nuovo source
- [Sequence di query](diagrams/sequence-query.md) — sequenza di una domanda → risposta → nuova pagina

## 📜 Operazioni

- [`log.md`](log.md) — diario append-only di tutte le operazioni
- [`CLAUDE.md`](CLAUDE.md) — schema (regole per gli agenti AI)

---

*Pagine totali: 11 — Last updated by LLM agent: 2026-05-10*
