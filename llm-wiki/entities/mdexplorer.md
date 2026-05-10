---
title: MdExplorer
kind: entity
tags: [prodotti, markdown, knowledge-management, electron]
last_updated: 2026-05-10
---

# MdExplorer

## Sintesi

MdExplorer è un editor markdown professionale per Spec Driven Development, sviluppato dal 2021 da [Carlo Salaroglio](carlo-salaroglio.md) e rilasciato come open source nell'Ottobre 2025 sotto licenza MIT. Combina editing markdown, integrazione Git, diagrammi PlantUML, AI assistant con LLM locale, ed export PDF/Word — il tutto come desktop app cross-platform basata su Electron. È particolarmente adatto come substrato per implementare il pattern [LLM Wiki](../concepts/llm-wiki.md).

## Punti chiave

- Open source dall'Ottobre 2025, licenza MIT [fonte: [README ufficiale](https://github.com/salaroglio/MdExplorer)]
- Stack: ASP.NET Core 8.0 + Angular 11 + Electron + LLamaSharp [fonte: [README](https://github.com/salaroglio/MdExplorer)]
- Architettura tre database SQLite: User settings, Engine (per progetto), Project (locale)
- Supporta nativamente file `CLAUDE.md` come "schema document" per agenti AI
- Indicizzazione semantica locale via `nomic-embed-text` (no cloud)
- Embedding di app esterne via `.mdeapps.json` + iframe (può ospitare Claude Code, Copilot CLI)
- Supporta tutti i requisiti del pattern LLM Wiki out-of-the-box [fonte: [concepts/llm-wiki](../concepts/llm-wiki.md)]

## Perché è adatto al pattern LLM Wiki

| Requisito LLM Wiki | Feature MDE |
|---|---|
| Progetti markdown con cross-link | Project-based, link tracking nativo |
| Schema document AI-readable | `CLAUDE.md` supportato nativamente |
| Versioning del wiki | Git integrato (LibGit2Sharp) |
| Search rapido | Full-text + semantic embeddings |
| Diagrammi nelle pagine | PlantUML embedded, render live |
| LLM locale | LLamaSharp |
| Embed agenti esterni | App Store + iframe |

## Vedi anche

- [Carlo Salaroglio](carlo-salaroglio.md) — creatore
- [LLM Wiki](../concepts/llm-wiki.md) — il pattern supportato
- Repository: https://github.com/salaroglio/MdExplorer
- Sito: https://www.mdexplorer.net

## Storico

- 2026-05-10 — pagina creata (entità menzionata in 2 sources senza pagina dedicata)
