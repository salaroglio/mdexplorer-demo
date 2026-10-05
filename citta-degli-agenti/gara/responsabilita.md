---
mde_type: ownership
title: Chi risponde di quale agente
---

# Chi risponde di quale agente

## TL;DR

Ogni agente della gara lavora per una persona: gira solo sul computer di quella persona, ed è lei a valutare ciò che l'agente
scrive. Questa tabella dice chi. All'inizio è vuota: finché un agente non ha un responsabile, non parte.

- In un'azienda vera le righe sarebbero quattro, una per persona: account manager, tecnico, legale, delivery.
- In questo demo le parti le fai tutte tu: dichiari tuoi i quattro agenti con un clic.
- La riga la scrive MdExplorer quando dici «è mio»; la persona si riconosce dall'email git.

## La tabella

| Ambito | Responsabile | Git Email | Agenti |
|--------|--------------|-----------|--------|

## Come si riempie

1. Apri **Città degli agenti** (le due persone nella barra degli strumenti).
2. In alto leggi chi sei per questo progetto: è la tua email git.
3. Clicca **Sono tutti miei**: MdExplorer aggiunge qui quattro righe con il tuo nome.

Da quel momento i quattro agenti rispondono a te e puoi abilitarli.

## Perché esiste

Un agente scrive documenti che qualcuno deve leggere e approvare. Se non è chiaro chi, nessuno ne risponde. Per questo MdExplorer
applica tre regole:

| Di chi è l'agente | Che cosa succede |
|---|---|
| Tuo | lavora sul tuo computer |
| Di un collega | lavora sul computer del collega, mai sul tuo |
| Di nessuno | non parte, e te lo dice |

## Con quattro persone vere

Ognuno dichiara suo il proprio agente dal proprio computer, e la tabella diventa così (i nomi sono inventati):

```text
| Ambito      | Responsabile | Git Email                 | Agenti                |
| Commerciale | Anna Rossi   | anna.rossi@pentagroup.it  | account-manager       |
| Tecnica     | Marco Bianchi| marco.bianchi@pentagroup.it | responsabile-tecnico |
| Contratti   | Sara Verdi   | sara.verdi@pentagroup.it  | responsabile-legale   |
| Delivery    | Luca Neri    | luca.neri@pentagroup.it   | responsabile-delivery |
```

Il documento è un file del progetto: sta in git, lo vede tutto il gruppo e ogni modifica ha un autore.

[Il caso della gara](README.md) · [Indice della sezione](../README.md)
