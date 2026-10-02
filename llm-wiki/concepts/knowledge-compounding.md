---
title: Knowledge Compounding
kind: concept
tags: [knowledge-management, principle]
last_updated: 2026-05-10
---

# Knowledge Compounding

## Summary

**Knowledge compounding** is the principle that useful knowledge **must build up over time** instead of being derived again at every query. It is the founding idea of the [LLM Wiki](llm-wiki.md) pattern: every interaction with the LLM should leave a lasting legacy in the form of wiki pages, not just a short-lived answer in a chat.

## Key points

- The problem with traditional RAG systems: every query redoes the work from the start, and knowledge "evaporates" between one session and the next [source: [sources/2026-04-beyond-rag-article](../sources/2026-04-beyond-rag-article.md)]
- The problem with traditional chats (ChatGPT, Claude.ai): the context is limited to one conversation, with no long-term persistence
- The idea of compounding: **every useful answer** must be saved as a page, and **every new source** updates the existing pages
- Result: the wiki grows and gets better over time, and later queries start from a richer state
- Karpathy's analogy: *"the wiki is the codebase, the LLM is the programmer, the human is the PM"* [source: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]

## Practical principles

1. **No short-lived chats** — if the answer is worth it, it becomes a page
2. **Update over recompute** — prefer updating an existing page to looking up its content from scratch
3. **Contradictions are first-class** — when a new source contradicts a page, flag it instead of overwriting
4. **Index everything** — `index.md` is the TOC, it must reflect everything

## See also

- [LLM Wiki](llm-wiki.md) — the pattern that embodies this principle
- [RAG vs Wiki](rag-vs-wiki.md) — the comparison with the pattern without compounding

## History

- 2026-05-10 — page created from the ingest of `sources/2026-04-karpathy-gist`
