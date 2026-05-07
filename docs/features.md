---
title: Feature MDE-specifiche
order: 2
---

# ✨ Feature di MdExplorer

Queste sono le funzionalità che rendono MdExplorer più di un "renderer markdown".

## 🌳 Albero lazy con auto-update

L'albero a sinistra **non carica tutto in memoria** alla prima apertura: usa lazy loading per cartella. Quando aggiungi/rinomini/sposti un file, il backend invia un evento SignalR (`fileCreated`, `folderRenamed`, ecc.) e l'albero si aggiorna **senza refresh manuale**.

## 🧠 Indicizzazione semantica

Ogni file `.md` salvato viene processato in background:

1. Segmentazione (testo / code blocks / plantuml)
2. Chunking (max 2000 caratteri per chunk)
3. Generazione embeddings via `nomic-embed-text` (locale, niente API esterne)
4. Salvataggio in EngineDB

Risultato: puoi cercare semanticamente nel progetto invece che con keyword exact-match.

## 🎨 Editor inline

Doppio-click su un file → **editor inline**, non un dialog modale. Salvi inline, e gli altri tab dello stesso file si aggiornano live (sempre via SignalR).

## 🤖 AI Commit messages

Quando fai commit, MDE può **scriverti il messaggio di commit** usando il diff. Provider supportati:

- GitHub Copilot CLI
- Google Gemini
- Local LLM (qualsiasi compatibile con OpenAI API)

## 👥 MdE Team

Vedi i partecipanti del progetto come "gemme" colorate sulle card e nella title-bar. Click → apri direttamente la chat Microsoft Teams via `msteams://`.

## 🚀 App Store interno

`.mdeapps.json` nel progetto definisce **applicazioni esterne** che MDE può lanciare embedded (iframe). Esempio: linkare un dashboard interno, un Mermaid editor, un tool custom.

## 🛰️ Mark — l'assistente onboarding

Hai sicuramente già incontrato Mark, l'astronauta che ti guida. Clicca il **`?`** nella title-bar quando ti serve un aiuto:

- 🪐 **Crea progetto demo** — sei qui adesso!
- ▶ **Next** — micro-pillole su feature meno ovvie

Mark si può anche **sganciare** in una finestra separata (utile su monitor multipli).

---

## Link incrociati

- [Schema architetturale](architecture.md)
- [README del progetto demo](../README.md)
- [Sintassi markdown](../02-markdown-basics.md)
- [Primi passi](../01-getting-started.md)
