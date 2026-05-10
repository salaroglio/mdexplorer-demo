---
title: Knowledge Compounding
kind: concept
tags: [knowledge-management, principio]
last_updated: 2026-05-10
---

# Knowledge Compounding

## Sintesi

**Knowledge compounding** è il principio per cui la conoscenza utile **deve accumularsi nel tempo** invece di essere ri-derivata ad ogni query. È l'idea fondante del pattern [LLM Wiki](llm-wiki.md): ogni interazione con l'LLM dovrebbe lasciare un'eredità durevole sotto forma di pagine wiki, non solo una risposta effimera in chat.

## Punti chiave

- Il problema dei sistemi RAG tradizionali: ogni query rifa il lavoro daccapo, la conoscenza "evapora" tra una sessione e l'altra [fonte: [sources/2026-04-beyond-rag-article](../sources/2026-04-beyond-rag-article.md)]
- Il problema delle chat tradizionali (ChatGPT, Claude.ai): il contesto è limitato a una conversazione, niente persistenza di lungo periodo
- L'idea del compounding: **ogni risposta utile** deve essere salvata come pagina, **ogni nuova source** aggiorna le pagine esistenti
- Risultato: il wiki cresce e si raffina nel tempo, le query successive partono da uno stato più ricco
- Analogia di Karpathy: *"il wiki è il codebase, l'LLM è il programmatore, l'umano è il PM"* [fonte: [sources/2026-04-karpathy-gist](../sources/2026-04-karpathy-gist.md)]

## Principi pratici

1. **Niente chat effimere** — se la risposta vale, diventa una pagina
2. **Update over recompute** — preferisci aggiornare una pagina esistente piuttosto che cercarne il contenuto da zero
3. **Contradditions are first-class** — quando una nuova source contraddice una pagina, segnala invece di sovrascrivere
4. **Index everything** — `index.md` è il TOC, deve riflettere tutto

## Vedi anche

- [LLM Wiki](llm-wiki.md) — il pattern che incarna questo principio
- [RAG vs Wiki](rag-vs-wiki.md) — il confronto col pattern senza compounding

## Storico

- 2026-05-10 — pagina creata da ingest di `sources/2026-04-karpathy-gist`
