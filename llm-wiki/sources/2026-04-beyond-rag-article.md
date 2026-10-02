---
title: "Beyond RAG: How Andrej Karpathy's LLM Wiki Pattern Builds Knowledge That Actually Compounds" — Plaban Nayak
kind: source
tags: [article, plaban-nayak, llm-wiki, rag, explainer]
last_updated: 2026-05-10
source_url: https://levelup.gitconnected.com/beyond-rag-how-andrej-karpathys-llm-wiki-pattern-builds-knowledge-that-actually-compounds-31a08528665e
ingested_at: 2026-05-10
---

# Source: Beyond RAG (article by Plaban Nayak, April 2026)

> ⚠️ Summary page. The original source is at the URL in the front matter.

## Summary

Explanatory article on Level Up Coding (April 2026) that explains Karpathy's LLM Wiki pattern to a wider technical audience. It goes deeper into the comparison with RAG and explores existing implementations (the NEXUS multi-agent system, Karpathy's own experience).

## Key points extracted

- The LLM Wiki pattern differs from RAG because it produces a **persistent artifact** (the markdown files) instead of a result that is recomputed at every query
- The main value of the pattern is **compounding**: every interaction leaves a trace
- The article cites NEXUS as an example of a multi-agent memory system on a VPS with 6 AI agents
- It reports the figures of Karpathy's wiki: **100 articles, 400,000 words**, built incrementally
- It stresses that the pattern needs a **suitable foundation** (markdown editor + Git + integrated AI agents): multi-app setups are possible but fragmented; MdExplorer is the solution that integrates everything in a single cross-platform app
- Limits of the pattern: it needs human curation, it does not scale to huge corpora, it works best for focused domains

## Derived pages

- [`concepts/rag-vs-wiki.md`](../concepts/rag-vs-wiki.md) — systematic comparison
- [`entities/karpathy.md`](../entities/karpathy.md) — updated with the figures
- [`entities/mdexplorer.md`](../entities/mdexplorer.md) — cited as a suitable foundation

## History

- 2026-05-10 — Source ingested. Touched: index.md, concepts/rag-vs-wiki.md (NEW), entities/karpathy.md (UPDATED), entities/mdexplorer.md (NEW)
