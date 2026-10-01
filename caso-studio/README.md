---
title: Il caso di studio
---

# Il caso di studio: un assistente AI per l'help desk

> **TL;DR** — Alpina Servizi è un'azienda inventata che vuole provare un assistente AI per il suo help desk.
> Questa cartella contiene i documenti del progetto pilota, scritti come li scriverebbe un gruppo di lavoro
> vero. Serve a provare MdExplorer e MarkAgent su qualcosa che somiglia al lavoro di tutti i giorni.

## I documenti

| Documento | Chi lo ha scritto | Cosa contiene |
|---|---|---|
| [Obiettivi e requisiti](01-obiettivi-e-requisiti.md) | responsabile del pilota | perché si fa, cosa deve fare l'assistente |
| [Architettura](02-architettura.md) | sistemi informativi | i componenti, il percorso di un ticket, i dati |
| [Piano del pilota](03-piano-del-pilota.md) | responsabile del pilota | fasi, calendario, metriche, rischi |
| [Verbale del 18 settembre](verbali/2026-09-18-comitato-guida.md) | responsabile del pilota | decisioni e azioni del comitato guida |
| [Slide per il comitato](slide-comitato.md) | responsabile del pilota | la presentazione della prossima riunione |

Accanto ai documenti ci sono due file che i documenti usano senza copiarli:

- `dati/metriche-obiettivo.json`, i numeri del pilota;
- `mockup/pannello-operatore.html`, il prototipo della schermata dell'operatore.

## La sfida: tre incongruenze

I documenti sono stati scritti in momenti diversi da persone diverse, e non dicono tutti la stessa cosa.
Ci sono **tre incongruenze**, messe apposta. Succede in ogni progetto vero.

Chiedi a MarkAgent di trovarle:

> Confronta requisiti, architettura, piano e verbale del caso di studio. Quali incongruenze trovi?
> Per ognuna cita il documento e il punto.

Poi chiedigli di sistemarle, e guarda nella scheda «Differenze» cosa ha cambiato prima di accettare.

## Altre cose da chiedere

> Riassumi in cinque righe a che punto è il pilota e cosa resta da decidere.

> Scrivi il verbale del comitato del 23 ottobre partendo dalle slide, con le decisioni ancora da prendere.

> Aggiungi all'architettura un diagramma di sequenza dell'anonimizzazione decisa nel verbale.

Come funziona MarkAgent è spiegato in [MarkAgent](../tour/03-markagent.md).

[Torna all'inizio](../README.md)
