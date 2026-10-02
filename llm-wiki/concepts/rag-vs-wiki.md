---
title: RAG vs LLM Wiki
kind: concept
tags: [knowledge-management, comparison, rag]
last_updated: 2026-05-10
---

# RAG vs LLM Wiki

## Summary

**RAG** (Retrieval-Augmented Generation) and **LLM Wiki** are two alternative approaches for giving an LLM access to domain-specific knowledge. RAG runs retrieval on raw documents at every query; LLM Wiki builds a condensed wiki maintained by the LLM itself. The differences run deep in cost, in the quality of the answers, and in maintainability.

## Comparison

| Aspect | RAG | LLM Wiki |
|---|---|---|
| **Source of knowledge** | Raw documents (PDF, HTML, transcripts) | Condensed markdown wiki |
| **Storage** | Vector DB (embeddings) | Markdown files on disk |
| **Operation per query** | Embedding + retrieval + reranking + generation | Read `index.md` + read 2-5 pages + synthesis |
| **Knowledge compounding** | ❌ Knowledge does not build up | ✅ Every useful answer becomes a page |
| **Visibility of the knowledge** | ❌ The chunks are opaque | ✅ Pages you can read, diff and version |
| **Handling of contradictions** | ❌ Hidden in the chunks | ✅ Flagged explicitly |
| **Marginal cost per query** | Vector search + LLM call | LLM call only (search is a grep on markdown) |
| **Setup** | Ingestion pipeline + vector DB | Markdown + a CLAUDE.md schema |
| **When to use it** | Large, mixed corpora, very varied queries | Specific domains, stable knowledge, a few expert users |

## The two approaches complement each other

The [LLM Wiki](llm-wiki.md) pattern does not replace RAG in every case. Practical guidelines:

- **Use RAG** when: the corpus is huge (>10k documents), queries are very mixed, every user has different needs, there is no budget for human curation
- **Use LLM Wiki** when: the domain is focused, there are a few power users (or just one), the quality of the answer matters more than coverage, you want to capitalize on every interaction

In some projects they can coexist: the wiki captures the stable, curated knowledge, and RAG covers the long tail of raw documents that have not been processed yet.

## See also

- [LLM Wiki](llm-wiki.md) — the wiki pattern
- [Knowledge Compounding](knowledge-compounding.md) — the principle of compounding
- [Andrej Karpathy](../entities/karpathy.md) — author of the comparison

## History

- 2026-05-10 — page created from the ingest of `sources/2026-04-beyond-rag-article`
