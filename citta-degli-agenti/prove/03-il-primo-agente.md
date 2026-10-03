---
title: Il primo agente al lavoro
---

# Prova 3: il primo agente al lavoro

## TL;DR

Lanciare un agente è come dare un compito a un collega: scrivi cosa vuoi, lui lavora per conto suo e ti scrive
quando ha finito. Questa prova ti fa lanciare `custode-verbali`, il più semplice dei tre, e leggere il risultato
nella posta in arrivo.

- Si lancia con l'icona del robot sul file `.agent.md`, nel pannello di sinistra.
- Lavora in una copia isolata del progetto e usa il motore AI scelto per il progetto.
- Il risultato arriva come messaggio nella posta; il testo completo dell'esecuzione si legge anche nell'elenco delle
  esecuzioni.

## Lancialo

1. Nel pannello di sinistra apri la cartella `.github` e poi `agents`. Vedi i file degli agenti, ognuno con una
   piccola icona di robot sulla destra.
2. Sulla riga di `custode-verbali.agent.md` clicca l'icona del robot, «Lancia agente». Se il pannello è stretto
   l'icona può essere tagliata: allarga un po' il pannello.
3. Si apre «Lancia agente — custode-verbali.agent.md». Nella casella «Prompt di lancio» scrivi:

   > Dimmi cosa ha deciso il comitato.

4. Guarda le opzioni sotto, senza cambiarle:

   | Opzione | Cosa fa |
   |---|---|
   | Motore | «Claude Code», «Copilot» o «opencode»: quale motore AI fa il lavoro. Il preselezionato è quello del progetto |
   | Modello | lascialo vuoto: sceglie il motore |
   | «Lavora in un posto di lavoro isolato» | l'agente lavora in una copia del progetto, non nella tua cartella |

5. Clicca **Lancia ora**.

La finestra si chiude e compare «Agente "custode-verbali.agent.md" avviato in background».

## Aspetta

Dopo mezzo minuto circa compare un avviso: «🤖 Agente "custode-verbali.agent.md" completato.» e sul fumetto
«Messaggi degli agenti» nella barra degli strumenti compare un numero, un messaggio non letto.

## Leggi il risultato

Clicca il fumetto. La scheda **Posta in arrivo** ha un messaggio di `custode-verbali` che comincia con
**`[ESITO]`**:

```text
[ESITO]
- D1 — Il pilota è approvato — riga 37.
- D2 — La durata è di 6 settimane — riga 38.
- D3 — Partecipano 12 operatori del turno diurno — riga 39.
- D4 — Nessun testo di ticket esce dalla rete senza essere stato anonimizzato — riga 40.
- D5 — La valutazione delle bozze si fa con un clic: accettata, modificata, scartata — riga 41.
```

Le parole possono cambiare, perché dietro c'è un modello: le cinque decisioni, no. I numeri di riga possono sbagliare di
una o due righe: controllale nel
[verbale](../../caso-studio/verbali/2026-09-18-comitato-guida.md).

## Cosa è successo

- `custode-verbali` ha letto il verbale, e solo quello: è il suo documento.
- Poi ha scritto il risultato **a te**, con uno strumento della città che si chiama `send_agent_message`. È
  l'unico modo in cui un agente ti scrive: se lo scrivesse solo nella sua risposta, resterebbe nel registro del
  servizio e tu non lo vedresti.
- Non ha modificato nessun file: nella cartella del progetto non è cambiato niente.

## E se non succede niente

- **Nessun avviso dopo due minuti.** Il motore AI non risponde: controlla che la riga di comando (`copilot`,
  `claude` o `opencode`) sia installata e con l'accesso fatto, o scegli un altro motore nella finestra di lancio.
- **Il fumetto non ha il numero.** Apri la scheda «Posta in arrivo» e clicca **Aggiorna**.
- **Il messaggio non arriva ma l'agente ha finito.** Un modello a volte scrive l'esito solo nella propria risposta e
  non lo invia. La risposta si legge comunque: tasto destro sul file dell'agente → **Schedulazione agente…** →
  **Esecuzioni** → **Mostra l'output** sulla riga più recente. Questo pulsante c'è nelle versioni di MdExplorer
  successive al 3 ottobre 2026.

[Prova 4: il dialogo tra due agenti](04-il-dialogo.md) · [Indice della sezione](../README.md)
