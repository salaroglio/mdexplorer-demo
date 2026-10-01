---
title: Word, PDF e sito
---

# Word, PDF e sito

## TL;DR

Il markdown è il formato di lavoro, ma chi riceve il risultato vuole spesso un file che conosce. MdExplorer
produce un documento Word da un documento, e un PDF o un sito da una presentazione. Il file markdown resta
la sola fonte: i formati di consegna si rigenerano quando serve.

- Un documento diventa **Word**, con il modello grafico dell'azienda.
- Una presentazione diventa **PDF**, una pagina per slide.
- Una presentazione diventa un **sito** in uno zip, con tutto ciò che i suoi link raggiungono.

## Da un documento a Word

1. Apri [i requisiti del caso di studio](../caso-studio/01-obiettivi-e-requisiti.md).
2. Nella barra del documento premi «esporta in word».
3. MdExplorer risponde «Richiesta di esportazione accodata!». Quando il file è pronto compare un avviso
   con il pulsante «Apri cartella».

Per una cartella intera: tasto destro sulla cartella, poi «Esporta cartella in Word».

Il modello grafico si sceglie per documento: tasto destro sul documento, «impostazioni documento»,
«Template Microsoft Word». I modelli stanno nella cartella `.md/templates/word/` del progetto.

## Da una presentazione a PDF

1. Apri [la presentazione del comitato](../caso-studio/slide-comitato.md).
2. Nella barra premi «Esporta le slide in PDF» e scegli dove salvare.

Il PDF ha una pagina per slide, con gli sfondi.

## Da una presentazione a un sito

1. Apri [la presentazione di MdExplorer](../presentazione/mdexplorer.md).
2. Nella barra premi «Esporta in HTML».
3. Ottieni uno zip. Scompattalo e apri `index.html`: funziona senza MdExplorer.

Lo zip contiene la presentazione e tutto ciò che i suoi link raggiungono: le altre presentazioni, i
documenti, le pagine HTML, le immagini. I diagrammi restano interattivi. Il resoconto `_mde/resoconto.html`
dentro lo zip dice cosa è stato incluso e cosa no.

È il modo per lasciare a qualcuno il materiale di una riunione senza chiedergli di installare niente.

## Cosa serve

- Per Word: Pandoc, che l'installazione controlla all'avvio, e Word per aprire il risultato.
- Per PDF e sito: niente altro.

Avanti: [Git senza terminale](06-git.md) · Indietro: [Presentazioni](04-presentazioni.md) · [Torna all'inizio](../README.md)
