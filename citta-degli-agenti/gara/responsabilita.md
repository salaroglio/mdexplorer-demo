---
mde_type: ownership
title: Chi risponde di quale agente
---

# Chi risponde di quale agente

## TL;DR

Ogni agente della gara lavora per una persona: gira solo sul computer di quella persona, ed è lei a valutare ciò che l'agente
scrive. Questa tabella dice chi. All'inizio ha i quattro **ruoli** ma nessuna persona: finché un agente non ha un
responsabile, non parte.

- I ruoli sono quelli che il workflow nomina: chi decide se partecipare è l'«Account manager», chiunque lo sia.
- In questo demo i ruoli li prendi tutti tu, con un clic: MdExplorer scrive il tuo nome e la tua email nelle quattro righe.
- La persona si riconosce dall'email git; più persone con lo stesso ruolo sono un team.

## La tabella

| Ruolo | Responsabile | Git Email | Agenti |
|-------|--------------|-----------|--------|
| Account manager | | | account-manager |
| Responsabile tecnico | | | responsabile-tecnico |
| Responsabile legale | | | responsabile-legale |
| Responsabile delivery | | | responsabile-delivery |

## Come si riempie

1. Apri **Città degli agenti** (le due persone nella barra degli strumenti).
2. In alto leggi chi sei per questo progetto: è la tua email git.
3. Clicca **Sono tutti miei**: MdExplorer scrive il tuo nome e la tua email nelle quattro righe.

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
| Ruolo                 | Responsabile  | Git Email                   | Agenti                |
| Account manager       | Anna Rossi    | anna.rossi@pentagroup.it    | account-manager       |
| Responsabile tecnico  | Marco Bianchi | marco.bianchi@pentagroup.it | responsabile-tecnico  |
| Responsabile legale   | Sara Verdi    | sara.verdi@pentagroup.it    | responsabile-legale   |
| Responsabile delivery | Luca Neri     | luca.neri@pentagroup.it     | responsabile-delivery |
```

## Più persone per lo stesso agente

Un agente può rispondere a un **team**: basta una riga per ogni persona, con lo stesso agente. Per esempio due
responsabili tecnici (i nomi sono inventati):

```text
| Responsabile tecnico | Marco Bianchi | marco.bianchi@pentagroup.it | responsabile-tecnico |
| Responsabile tecnico | Paolo Gialli  | paolo.gialli@pentagroup.it  | responsabile-tecnico |
```

L'agente lavora sul computer di entrambi, ma **ogni lavoro è di una persona sola**: quando l'account manager preme «Avvia il
giro», sceglie chi dei due farà la scheda tecnica, e da lì ne risponde quella persona (anche se la scheda va rifatta).
Chi l'ha ricevuta la può passare a un collega del team con «Passa a un collega», per esempio prima delle ferie.

Il documento è un file del progetto: sta in git, lo vede tutto il gruppo e ogni modifica ha un autore.

[Il caso della gara](README.md) · [Indice della sezione](../README.md)
