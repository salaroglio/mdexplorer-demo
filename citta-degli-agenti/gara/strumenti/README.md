---
title: Strumenti della gara
---

# Strumenti della gara

## TL;DR

Programmi che gli agenti lanciano quando un lavoro deve essere esatto e ripetibile, invece di farlo a parole.

- `scarica-documento-di-gara.mjs <codice>`: scarica dal portale di Nordica il documento di gara del bando in
  `../documenti-di-gara/<codice>-capitolato.md`. Se il bando non ha un documento allegato si ferma e lo dice.
- Servono Node.js (c'è già dove girano Copilot e Claude Code) e nessun pacchetto.

Prova a mano, dalla radice del progetto:

```bash
node citta-degli-agenti/gara/strumenti/scarica-documento-di-gara.mjs NC-2027-014
```
