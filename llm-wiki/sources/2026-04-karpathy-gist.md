---
title: Karpathy gist on LLM Wiki (April 2026)
kind: source
tags: [karpathy, llm-wiki, primary-source]
last_updated: 2026-05-10
source_url: https://gist.github.com/karpathy/442a6bf555914893e9891c11519de94f
ingested_at: 2026-05-10
---

# Source: Karpathy gist on LLM Wiki

> ⚠️ This is a **summary page** — the original file is immutable and is at the link above. Do NOT change the summary in a way that alters the original claims; only add annotations if needed.

## Summary

In April 2026 Andrej Karpathy publishes a GitHub gist in which he describes the **LLM Wiki** pattern, an alternative to RAG where an AI agent actively maintains a structured wiki of markdown pages instead of running retrieval at every query. The pattern has three layers (Raw Sources, Wiki, Schema) and emphasizes the principle of **knowledge compounding**.

## Key points extracted

- Three layers: **Raw Sources** (immutable), **Wiki** (maintained by the LLM), **Schema** (one config file)
- The schema file is typically `CLAUDE.md` — it defines conventions, naming, update workflow, lint criteria
- Standard files of the wiki: `index.md` (catalogue), `log.md` (append-only chronology), entity pages, concept pages, synthesis pages
- Ingest workflow: the LLM reads the source → summarizes → updates 10-15 relevant files → logs
- Query workflow: the LLM searches the pages via the index → synthesizes with citations → the answer can become a new page
- Periodic lint: finds contradictions, stale claims, orphan pages, missing cross-references, data gaps
- Optional tool `qmd` for local BM25/vector search when the wiki grows
- Karpathy's original signature phrase (it named the editor he used for his own experiments): *"\[Markdown editor\] is the IDE; the LLM is the programmer; the wiki is the codebase"*. Adapted to MdExplorer: *"MdExplorer is the IDE; the LLM is the programmer; the wiki is the codebase"*
- Karpathy's personal wiki has reached **100 articles and 400,000 words**

## Citable as

> Karpathy, Andrej. *"LLM Wiki: a persistent, structured knowledge base maintained by AI agents."* GitHub Gist, April 2026. https://gist.github.com/karpathy/442a6bf555914893e9891c11519de94f

## Derived pages (entities/concepts touched by this source)

- [`entities/karpathy.md`](../entities/karpathy.md) — author
- [`concepts/llm-wiki.md`](../concepts/llm-wiki.md) — the pattern
- [`concepts/knowledge-compounding.md`](../concepts/knowledge-compounding.md) — the principle
- [`diagrams/use-case.md`](../diagrams/use-case.md) — derived diagram
- [`diagrams/workflow-ingestion.md`](../diagrams/workflow-ingestion.md) — derived diagram

## History

- 2026-05-10 — Source ingested. Touched: index.md, entities/karpathy.md (NEW), concepts/llm-wiki.md (NEW), concepts/knowledge-compounding.md (NEW)
