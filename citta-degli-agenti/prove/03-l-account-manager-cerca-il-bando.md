---
title: L'account manager cerca il bando
---

# Prova 3: l'account manager cerca il bando

## TL;DR

Sei l'account manager di Pentagroup e hai un agente che controlla per te il sito dei bandi di Nordica. Lo lanci, lui legge
le procedure in corso, le confronta con quelle già viste e con i criteri di Pentagroup, e ti scrive **un messaggio**: cosa
c'è di nuovo, cosa scarta e perché, cosa ti propone. Non avvia niente da solo.

- Si lancia con l'icona del robot sul suo file, nel pannello di sinistra.
- Legge tre cose: il sito dei bandi (simulato), il registro dei bandi già visti e il profilo di Pentagroup.
- Il risultato arriva nella posta in arrivo, come messaggio che comincia con `[ESITO]`.

## Lancialo

1. Nel pannello di sinistra apri `.github` e poi `agents`. Sulla riga di `account-manager.agent.md` clicca l'icona del
   robot, «Lancia agente». Se il pannello è stretto, l'icona può essere tagliata: allargalo un po'.
2. Nella casella «Prompt di lancio» scrivi:

   > Controlla il portale dei bandi.

3. Lascia le altre opzioni come sono (motore del progetto, modello vuoto, «Lavora in un posto di lavoro isolato»
   spuntato) e clicca **Lancia ora**.

Dopo circa un minuto compare «🤖 Agente "account-manager.agent.md" completato.» e sul fumetto «Messaggi degli agenti»
nella barra degli strumenti compare un numero.

## Leggi il messaggio

Clicca il fumetto: la scheda **Posta in arrivo** ha un messaggio di `account-manager`. Le parole cambiano, perché dietro c'è
un modello, ma il contenuto è questo:

```text
[ESITO]
NC-2027-014 — compatibile: piattaforma per enti locali coerente; dubbi sull'esperienza nella riscossione
coattiva e su tempi e condizioni (portale, profilo criteri 2–4).
NC-2027-012 — non compatibile: fornitura licenze fuori attività e scadenza tra 16 giorni, sotto i 21 richiesti
(portale, profilo criteri 1 e 5).
NC-2027-011 — non compatibile: manutenzione immobili fuori attività (portale, profilo criterio 1).
Vuoi che avvii il giro su NC-2027-014? Rispondi `avvia NC-2027-014`.
```

## Controllalo

Questo è il gesto che ti viene chiesto in tutto il caso: **verifichi**, non ti fidi. Tre controlli, due minuti:

1. Apri il [sito dei bandi](../gara/portale-nordica/bandi.md): le tre procedure in corso ci sono tutte? I codici sono giusti?
2. Apri il [profilo di Pentagroup](../gara/profilo-pentagroup.md), in fondo: i criteri sono quelli che l'agente cita? La
   «Data di lavoro» è l'8 marzo 2027: da lì alla scadenza di NC-2027-012 (24 marzo) sono **16 giorni**, e a quella di
   NC-2027-014 (30 aprile) sono **53**. Tornano?
3. Apri il [registro](../gara/registro-bandi.md): le due procedure già viste **non** sono nel messaggio. Perché?

## Cosa è successo

- L'agente ha letto tre file, e solo quelli: sono i suoi documenti.
- Ha **scartato** due procedure con un motivo che puoi controllare, e ne ha proposta una.
- Ha chiuso con una **domanda** e non con un'azione: l'avvio del giro lo decidi tu, con una risposta.
- Non ha modificato nessun file: nella cartella non è cambiato niente.

## E se non succede niente

- **Nessun avviso dopo due minuti.** Il motore AI non risponde: controlla che la riga di comando (`copilot`, `claude` o
  `opencode`) sia installata e con l'accesso fatto, o scegli un altro motore nella finestra di lancio.
- **Il fumetto non ha il numero.** Apri «Posta in arrivo» e clicca **Aggiorna**.
- **L'agente dice che non trova i file.** Controlla di aver aperto la cartella giusta: gli agenti cercano i documenti in
  `citta-degli-agenti/gara/`.

[Prova 4: avvia il giro](04-avvia-il-giro.md) · [Prova 2](02-abilita-gli-agenti.md) · [Indice della sezione](../README.md)
