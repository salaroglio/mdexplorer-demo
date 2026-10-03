---
title: Il lavoro che passa dalla tua approvazione
---

# Prova 6: il lavoro che passa dalla tua approvazione

## TL;DR

Gli agenti di questo demo si limitano a leggere. Un agente che **modifica i file** invece non lavora mai nella tua
cartella: lavora su una copia a parte, firma i commit con un nome suo e ti lascia un ramo da approvare. Questa
pagina mostra com'è fatto quel percorso e come provarlo, perché per provarlo serve un repository su cui puoi
scrivere.

- L'agente lavora in una copia isolata (`.worktrees/`) e firma `nome@agents.mde`.
- Il suo lavoro arriva come richiesta in «Messaggi degli agenti» → «Lavoro degli agenti»: **Autorizza**, **Ci metto mano**
  o **Rifiuta**.
- «Autorizza» fonde il ramo in `main` **e lo pubblica sul repository remoto**: per questo non è nel demo.

## Perché non è una prova del demo

Questo progetto è un clone di un repository pubblico: probabilmente non hai il permesso di scrivere sul remoto
`origin`. Il lavoro di un agente che modifica i file viene **pubblicato su `origin`** come ramo, e «Autorizza» scrive
anche su `main`. Chi ha quel permesso, come l'autore del demo, modificherebbe il `main` pubblico.

Se `origin` non è scrivibile, MdExplorer non perde il lavoro e non finge che sia andata: nella posta in arrivo ti
arriva un messaggio dell'agente che dice **perché** non è riuscito a pubblicarlo e dove sta il suo lavoro. Nelle
versioni di MdExplorer precedenti al 3 ottobre 2026 quell'errore restava solo nel log del servizio e nella finestra
non compariva niente.

## L'agente

Un agente che modifica i file dichiara `edit` tra gli strumenti. Questa è la scheda di un agente che porta il
piano del pilota in linea con il verbale:

```markdown
---
description: Allinea il piano del pilota alle decisioni del comitato
tools: [read, edit]
a2a:
  name: allineatore-piano
  role: Allineatore del piano del pilota
  skills:
    - id: allinea-piano
      description: Porta il piano in linea con le decisioni approvate nel verbale
  accepts_messages_from: ["*"]
mde: {origin: user, version: 1}
---

Sei l'allineatore del piano del pilota Alpina Servizi (cartella `caso-studio/`).

Come lavori:
1. Leggi i file direttamente con lo strumento di lettura file.
2. Modifica solo `caso-studio/03-piano-del-pilota.md`, e solo ciò che il verbale del comitato ha deciso.
3. Riassumi in due righe cosa hai cambiato.
```

## Come provarlo sul tuo repository

1. Fai un **tuo repository** del demo: un fork, oppure un repository nuovo su cui puoi scrivere. Clonalo e aprilo
   in MdExplorer.
2. Salva la scheda qui sopra in `.github/agents/allineatore-piano.agent.md`.
3. Accendi la città ([prova 1](01-accendi-la-citta.md)) e dai fiducia all'agente ([prova 2](02-registro-e-fiducia.md)).
   La finestra della fiducia dice che chiede `edit`.
4. Lancia l'agente dall'icona del robot sul suo file, lasciando spuntata la casella **«Lavora in un posto di lavoro
   isolato»**, con la richiesta: «Il verbale approva 6 settimane: aggiorna il piano.».
5. Dopo circa un minuto apri «Messaggi degli agenti» → **Lavoro degli agenti**.

## Cosa vedi

Una richiesta con il nome dell'agente, il ramo (`agent/<tuo nome>/allineatore-piano/...`), il numero di file toccati
e il loro elenco, per esempio `caso-studio/03-piano-del-pilota.md`. Tre pulsanti:

| Pulsante | Cosa fa |
|---|---|
| **Autorizza** | fonde il ramo in `main` e lo pubblica su `origin`. Il commit risulta dell'agente |
| **Ci metto mano** | apre il suo lavoro in una copia per correggerlo tu, e rimette l'agente in coda |
| **Rifiuta** | non fonde nulla; il ramo resta, non lo distrugge |

Nella cronologia git il commit dell'agente è firmato `allineatore-piano <allineatore-piano@agents.mde>`: dove ha
messo le mani lo vedi con `git blame`, non lo devi chiedere a nessuno.

## Cosa deve restare vero

- **Un agente che non cambia niente non apre nessuna richiesta.** I tre custodi della prova 4 lavorano in una copia
  isolata anche loro, ma senza modifiche non pubblicano niente.
- **Il lavoro dell'agente non tocca la tua cartella** finché non lo autorizzi.
- **La decisione è tua, per ogni consegna.** Non esiste una fusione automatica: la scelta di fonderle da sole è
  stata ritirata.

[Indice della sezione](../README.md) · [Torna all'inizio](../../README.md)
