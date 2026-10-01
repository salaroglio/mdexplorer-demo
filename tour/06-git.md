---
title: Git senza terminale
---

# Git senza terminale

## TL;DR

Git è ciò che rende il lavoro con l'AI controllabile: ogni modifica ha un autore e una data, e nessuna
versione va persa. MdExplorer lo mette a portata di chi non usa il terminale. Questa pagina mostra dove si vede
cosa è cambiato e come si salva e si condivide.

- La barra dice sempre quante modifiche sono da salvare, da scaricare e da pubblicare.
- La scheda «Differenze» mostra riga per riga cosa è cambiato, chiunque l'abbia scritto.
- Il messaggio di commit lo propone l'AI, lo approva la persona.

## Cosa è cambiato

A destra nella barra del documento ci sono tre contatori: «da committare», «da pullare», «da pushare».
Passandoci sopra si apre un pannello con una riga per ogni repository del progetto.

In fondo al pannello di sinistra, la scheda «Differenze» elenca i file cambiati. Un clic su un file mostra
le righe tolte e quelle aggiunte.

## Da provare

1. Apri [Documenti vivi](01-documenti-vivi.md) e correggi l'errore di battitura con il tasto destro.
2. Guarda il contatore «da committare»: è salito di uno.
3. Apri la scheda «Differenze» e leggi la riga cambiata.
4. Apri il pannello «Da committare» e premi «Committa».
5. Nella finestra «Messaggio di Commit» premi «Genera con AI», leggi la proposta e conferma.

Il commit resta sul tuo computer. «Pubblica» lo manda al repository remoto, se ne hai i permessi.

## La storia del progetto

Il pulsante con il nome del ramo apre un menu. «Cronologia» mostra tutti i commit, in tabella o in grafico.
«Branch» mostra i rami e permette di cambiarli.

## Perché conta quando lavora un agente

| Domanda | Dove si trova la risposta |
|---|---|
| Cosa ha cambiato l'agente? | scheda «Differenze», prima del commit |
| Chi ha approvato la modifica? | l'autore del commit, nella «Cronologia» |
| Quando è successo, e con quale motivo? | data e messaggio del commit, nella «Cronologia» |
| Si può tornare indietro? | sì: git conserva ogni versione di ogni file |

## Cosa serve

Git installato. Per scaricare e pubblicare servono la rete e l'accesso al repository remoto.
«Genera con AI» richiede un motore AI: vedi [MarkAgent](03-markagent.md).

Avanti: [Regole, skill e MCP](07-regole-skill-mcp.md) · Indietro: [Word, PDF e sito](05-word-pdf-sito.md) · [Torna all'inizio](../README.md)
