---
title: MarkAgent
---

# MarkAgent

## TL;DR

MarkAgent è l'agente AI di MdExplorer: una conversazione che legge e scrive i documenti del progetto
aperto. Usa il motore che il progetto ha scelto e le regole che il progetto si porta dietro. Questa pagina
dice dove si trova, come si sceglie il motore e cosa chiedergli sul caso di studio.

- Sta nella scheda «Mark Agent», in fondo al pannello di sinistra.
- Il motore si sceglie **una volta, per progetto**: GitHub Copilot, Claude Code oppure opencode.
- Ciò che scrive è una modifica nei file: la vedi nella scheda «Differenze» prima di accettarla.

## Dove si trova

In fondo al pannello di sinistra ci sono quattro schede: «Documenti progetto», «Differenze», «Mark Search»
e «Mark Agent». La scheda «Mark Agent» compare quando il progetto è un repository git, come questo.

Nella scheda trovi la casella «Chiedi a Mark Agent...», la tendina «Modello» e il pulsante
«Nuova sessione chat».

## Scegliere il motore

Nella pagina dei progetti, la rotella sulla scheda del progetto apre «Impostazioni Progetto».
Lì, nella scheda «AI & RAG», c'è il riquadro «Ambiente agentico».

| Scelta | Dove MdExplorer scrive regole e skill |
|---|---|
| GitHub Copilot | cartella `.github/` |
| Claude Code | cartella `.claude/` e file `CLAUDE.md` |
| opencode | cartella `.opencode/` e file `AGENTS.md` |

La scelta è scritta in un file del progetto, quindi vale per tutto il gruppo di lavoro. Tutte le funzioni
AI di MdExplorer usano quel motore: la conversazione, la spiegazione dei diagrammi, il messaggio di commit,
i test.

## Cosa chiedergli sul caso di studio

Il [caso di studio](../caso-studio/README.md) è un piccolo progetto scritto apposta. Copia una richiesta
nella casella di MarkAgent.

**Capire in fretta**

> Leggi i documenti della cartella caso-studio e dimmi in cinque righe di cosa parla il progetto e a che
> punto è.

**Trovare ciò che non torna**

> Confronta requisiti, architettura, piano e verbale del caso di studio. Quali incongruenze trovi?
> Per ognuna cita il documento e il punto.

Nei documenti ci sono tre incongruenze messe apposta. Le trova tutte?

**Mettere in ordine**

> Aggiorna requisiti, piano e file dei dati del caso di studio con le decisioni D2 e D3 del verbale.

Poi apri la scheda «Differenze»: ogni riga cambiata è lì, da leggere prima di fare commit.

**Preparare una riunione**

> Aggiungi alla presentazione caso-studio/slide-comitato.md una slide con i tre rischi principali del piano.

Apri la [presentazione del comitato](../caso-studio/slide-comitato.md): la slide nuova è già lì.

## Le altre porte verso lo stesso agente

| Dove | Cosa fa |
|---|---|
| scheda «Mark Search» | cerca nei documenti del progetto e risponde citando le fonti |
| tasto destro su un diagramma, «💬 Ask to MarkAgent» | spiega l'elemento |
| tasto destro su un punto di una slide, «💬 Chiedi a MarkAgent» | spiega quel punto con i documenti del progetto |
| selezione di testo, «✨ Usa AI» | riscrive il pezzo selezionato, con approvazione |
| finestra del commit, «Genera con AI» | propone il messaggio di commit |

## Dove vanno i dati

I documenti restano sul computer e nel repository git. Quando chiedi qualcosa a MarkAgent, il testo che gli
serve va al fornitore del motore scelto, con le condizioni del contratto che l'azienda ha con quel fornitore.
La ricerca nei documenti e l'indice sono locali.

## Cosa serve

- Il progetto deve essere un repository git.
- La riga di comando del motore scelto, installata e con l'accesso fatto: `copilot`, `claude` oppure `opencode`.
- La rete.

Avanti: [Presentazioni](04-presentazioni.md) · Indietro: [Diagrammi](02-diagrammi.md) · [Torna all'inizio](../README.md)
