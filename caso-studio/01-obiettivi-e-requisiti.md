---
title: Obiettivi e requisiti del pilota
author: Giulia Ferraris
---

# Obiettivi e requisiti del pilota

## TL;DR

Alpina Servizi vuole provare un assistente AI che prepara le bozze di risposta ai ticket dell'help desk.
Questo documento dice perché, cosa deve fare l'assistente e cosa non deve fare mai. La decisione di
inviare una risposta resta sempre all'operatore.

- L'assistente **propone**, l'operatore **decide**: nessuna risposta parte da sola.
- Il pilota dura **8 settimane** e coinvolge **20 operatori** del turno diurno.
- Nessun dato personale dei clienti esce dalla rete aziendale (requisito R6).

## Il contesto

Alpina Servizi gestisce impianti di riscaldamento per condomini e piccole aziende. L'help desk riceve circa
1.900 ticket al mese: richieste di intervento, domande sulle bollette, segnalazioni di guasto.

Oggi un operatore impiega in media più di quattro ore per dare la prima risposta. Buona parte del tempo va
nella ricerca: la risposta giusta esiste quasi sempre, ma è sparsa fra manuali, vecchi ticket e la memoria
dei colleghi più esperti.

## Gli obiettivi

| # | Obiettivo | Come si misura |
|---|---|---|
| O1 | Ridurre il tempo della prima risposta | da 4 h 10 min a 1 h 30 min |
| O2 | Risolvere più ticket al primo contatto | dal 58% al 70% |
| O3 | Migliorare la soddisfazione dei clienti | da 3,9 ad almeno 4,2 su 5 |
| O4 | Capire se gli operatori si fidano delle bozze | almeno il 40% accettate senza modifiche |

I valori di partenza e gli obiettivi sono nel file dei dati, che è la fonte unica anche per
l'[architettura](02-architettura.md) e per il [piano](03-piano-del-pilota.md):

```text(./dati/metriche-obiettivo.json)
```

## I requisiti

| # | Requisito | Priorità |
|---|---|---|
| R1 | Per ogni ticket nuovo l'assistente prepara una **bozza di risposta** entro 30 secondi | alta |
| R2 | Ogni bozza **cita le fonti** usate: articoli della base di conoscenza o ticket già chiusi | alta |
| R3 | La bozza non viene **mai inviata** senza che un operatore la approvi | alta |
| R4 | Se la fiducia è sotto la soglia, l'assistente **non propone niente** e lo dice | alta |
| R5 | L'operatore valuta ogni bozza: accettata, modificata, scartata | media |
| R6 | **Nessun dato personale** dei clienti esce dalla rete aziendale | alta |
| R7 | Ogni bozza resta tracciata: chi l'ha approvata, quali fonti, quale modello | media |
| R8 | Il pilota coinvolge **20 operatori** del turno diurno per **8 settimane** | media |

## Cosa resta fuori

- Le risposte automatiche ai clienti, senza operatore.
- I ticket su contratti e contenziosi: restano all'ufficio legale.
- Il canale telefonico: il pilota riguarda solo i ticket scritti.

## Chi decide

| Ruolo | Persona | Decide su |
|---|---|---|
| Sponsor | Marta Colombo, direzione operativa | avvio, arresto, estensione |
| Responsabile del pilota | Giulia Ferraris, help desk | perimetro e metriche |
| Sicurezza e privacy | Paolo Gentile, DPO | requisito R6 |
| Architettura | Luca Bianchi, sistemi informativi | scelte tecniche |

Le decisioni prese finora sono nel [verbale del comitato guida](verbali/2026-09-18-comitato-guida.md).
