---
title: MdExplorer
kind: entity
tags: [products, markdown, knowledge-management, electron]
last_updated: 2026-05-10
---

# MdExplorer

## Summary

MdExplorer is a professional markdown editor for Spec Driven Development, developed since 2021 by [Carlo Salaroglio](carlo-salaroglio.md) and released as open source in October 2025 under the MIT license. It combines markdown editing, Git integration, PlantUML diagrams, an AI assistant that runs on an AI agent (GitHub Copilot, Claude Code or opencode), and PDF/Word export — all as a cross-platform desktop app based on Electron. It is particularly suitable as a foundation for implementing the [LLM Wiki](../concepts/llm-wiki.md) pattern.

## Key points

- Open source since October 2025, MIT license [source: [official README](https://github.com/salaroglio/MdExplorer)]
- Stack: ASP.NET Core 8.0 + Angular 11 + Electron + LLamaSharp [source: [README](https://github.com/salaroglio/MdExplorer)]
- Architecture with three SQLite databases: User settings, Engine (per project), Project (local)
- Natively supports `CLAUDE.md` files as the "schema document" for AI agents
- Local semantic indexing via `nomic-embed-text` (no cloud)
- Embedding of external apps via `.mdeapps.json` + iframe (it can host Claude Code, Copilot CLI)
- Supports all the requirements of the LLM Wiki pattern out of the box [source: [concepts/llm-wiki](../concepts/llm-wiki.md)]

## Why it suits the LLM Wiki pattern

| LLM Wiki requirement | MDE feature |
|---|---|
| Markdown projects with cross-links | Project-based, native link tracking |
| AI-readable schema document | `CLAUDE.md` natively supported |
| Versioning of the wiki | Built-in Git (LibGit2Sharp) |
| Fast search | Full-text search |
| Diagrams in the pages | Embedded PlantUML, live rendering |
| An LLM that maintains the wiki | An AI agent (GitHub Copilot, Claude Code or opencode) |
| Embed external agents | App Store + iframe |

## See also

- [Carlo Salaroglio](carlo-salaroglio.md) — creator
- [LLM Wiki](../concepts/llm-wiki.md) — the supported pattern
- Repository: https://github.com/salaroglio/MdExplorer
- Site: https://www.mdexplorer.net

## History

- 2026-05-10 — page created (entity mentioned in 2 sources without a dedicated page)
