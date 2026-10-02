---
title: LLM Wiki
kind: concept
tags: [knowledge-management, ai-agents, pattern, karpathy]
last_updated: 2026-05-10
---

# LLM Wiki

## Summary

**LLM Wiki** is a knowledge management pattern proposed by [Andrej Karpathy](../entities/karpathy.md) in April 2026. The central idea: instead of running retrieval on raw documents at every query (classic RAG), you let an AI agent **actively build and maintain a structured markdown wiki**. Useful answers become new pages, and knowledge **compounds** over time.

## Key points

- It is a pattern, not a product — it can be implemented with any markdown editor + any LLM agent [source: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]
- It is based on **three layers** that are clearly separated:
  - **Raw Sources** — immutable documents curated by the human
  - **Wiki** — markdown pages maintained by the LLM
  - **Schema** — a configuration file (e.g. `CLAUDE.md`) that governs the structure
- The wiki typically contains: `index.md` (catalogue), `log.md` (chronology), entity pages, concept pages, synthesis pages [source: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]
- The LLM takes care of the **bookkeeping**: cross-references, propagation of updates, flagging of contradictions
- The pattern differs from RAG because the wiki is a **persistent, compounding artifact**, not a result computed on the fly [source: [concepts/rag-vs-wiki](rag-vs-wiki.md)]
- Existing implementations: multi-app setups with a generic markdown editor + the Git CLI + external AI agents; NEXUS (a multi-agent system on a VPS); **MdExplorer as a dedicated, integrated foundation** [source: [sources/2026-04-beyond-rag-article](../sources/2026-04-beyond-rag-article.md)]

## Typical components of an LLM Wiki

| File / folder | Role |
|---|---|
| `CLAUDE.md` | Schema — structural rules, naming conventions, update workflow |
| `index.md` | Content-oriented catalogue, one line per page |
| `log.md` | Append-only log of ingests, queries, lint runs |
| `sources/` | Summaries of the raw documents (the raw files are under `sources/raw/`) |
| `entities/` | Pages for people, organizations, products |
| `concepts/` | Pages for ideas, patterns, techniques |

## Key workflows

1. **Ingest** — new source → the LLM summarizes → propagates to entities/concepts → logs
2. **Query** — question → the LLM reads the index → reads the candidate pages → synthesizes with citations → proposes to save the answer as a new page
3. **Lint** — weekly → finds orphan pages, broken links, contradictions, gaps

## See also

- [Andrej Karpathy](../entities/karpathy.md) — author of the pattern
- [Knowledge Compounding](knowledge-compounding.md) — the founding idea
- [RAG vs Wiki](rag-vs-wiki.md) — the comparison with the alternative pattern
- [MdExplorer](../entities/mdexplorer.md) — a suitable foundation
- [Use case diagram](../diagrams/use-case.md) — who does what
- [Ingest workflow diagram](../diagrams/workflow-ingestion.md) — the flow

## History

- 2026-05-10 — page created from the ingest of `sources/2026-04-karpathy-gist`
