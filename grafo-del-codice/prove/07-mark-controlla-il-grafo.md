---
title: "Prova 7: Mark controlla il grafo"
---

# Prova 7: Mark controlla il grafo

## TL;DR

Il grafo è una **affermazione** sul codice, il sorgente è la **verità**. A una domanda precisa Mark può confrontarli: prima
legge com'è fatto il grafo (`code_ontology`), poi prende i collegamenti, apre il sorgente punto per punto e dà un verdetto,
con i numeri. Se un collegamento è sbagliato dice chi l'ha prodotto e che cosa si può correggere.

- Tre domande da copiare sul programma della [prova 6](06-visual-basic-e-sql.md): la struttura del grafo, una relazione da verificare, un buco da trovare.
- Mark segue la skill `mde-code-check`, che MdExplorer installa nel progetto insieme a quella del grafo.
- Niente si cambia da solo: una correzione è una proposta che approvi tu, o una **rilevazione** che va a chi mantiene MdExplorer.

## Prima di cominciare

Fai prima la prova 6: questa usa il grafo di `esempio-vb`. Serve il motore AI del progetto.

## Domanda 1: com'è fatto il grafo

> Prima di rispondere sul codice di esempio-vb: com'è organizzato il grafo, e che cosa ha prodotto il parser del Visual Basic in questo progetto?

Mark chiama `code_ontology`. Lo strumento restituisce due cose.

- Il **TBox** del grafo, in Turtle: le classi di nodi (file, simbolo, parametro, arco, punto di chiamata, annotazione,
  descrizione), ogni proprietà con il suo significato e il suo tipo, le relazioni fra simboli e i valori ammessi per il
  tipo di simbolo e per la fiducia. È lo stesso per tutti i linguaggi.
- Per ogni linguaggio del progetto, **che cosa ha prodotto il suo parser**: quale estrattore e quale versione, quanti
  file, quali tipi di simbolo e quali relazioni, con i numeri. Per il Visual Basic ci sono `reads` e `writes`; per un
  linguaggio che non legge l'SQL non ci sono, e allora «chi scrive su questa tabella?» non ha risposta nel grafo.

È il passo che la skill chiede a Mark per primo: sapere che cosa c'è prima di cercarlo, e dire subito quando una domanda
chiede una relazione che quel linguaggio non produce.

## Domanda 2: una relazione da verificare

> È vero che Archivia scrive solo su STORICO_RAPPORTI? Verifica sul sorgente.

Qui la skill `mde-code-check` dà a Mark un metodo:

1. **L'affermazione**, in una riga, e i collegamenti dal grafo con la loro fiducia: `Archivia` → `writes` → `?`, ambigua.
2. **Il campione**: per un solo collegamento, quel collegamento; per una regola o un tipo di relazione, almeno dieci
   punti sparsi su file diversi, metà presi dal grafo e metà cercati nel sorgente.
3. **Il sorgente**, punto per punto, con un verdetto: giusto, sbagliato, o non decidibile dal codice.
4. **Chi ha prodotto il collegamento**, che decide che cosa si può fare.
5. **La risposta**, prima dal sorgente e poi con i numeri: «controllati 1, giusti 1».

La risposta onesta qui è *non decidibile dalla sola `Archivia`*: la tabella la sceglie il chiamante. Oggi l'unico
chiamante, `Avvio.Prepara`, passa `"STORICO_RAPPORTI"`; un chiamante nuovo potrebbe passarne un'altra. Il nodo `?` del
grafo è giusto: dice proprio questo.

## Domanda 3: un buco del grafo

> Nel programma esempio-vb c'è SQL che il grafo non ha collegato? Controlla tutte le stringhe.

Mark cerca le stringhe nel sorgente e le confronta con le relazioni del grafo. Una risposta completa nota due casi. `Conta`, con
`"SELECT COUNT(*) FROM (" & sql & ")"`: nessuna tabella, ed è giusto, la tabella sta nella query che arriva da fuori. E
`OperatoriAttivi`, che legge `OPERATORE` attraverso la costante: il grafo collega la costante alla tabella, non il metodo,
perché non registra chi legge un campo. È un limite noto, scritto nella [guida](../guida/come-funziona.md#cosa-il-grafo-non-sa-oggi).

## Che cosa si può correggere, e chi lo fa

| Il collegamento sbagliato viene da | Che cosa fa Mark |
|---|---|
| una **regola** che ha proposto lui e che tu hai approvato | la corregge e te la ripropone con lo stesso nome; se nessuna regola può essere giusta, e tu sei d'accordo, la ritira (`code_rule_remove`) con tutti i suoi collegamenti |
| un **pacchetto di linguaggio** (`.mde-languages/`) | corregge le regole del pacchetto e te lo ripropone |
| il **parser** di MdExplorer (C#, Visual Basic, Java…) | non può cambiarlo: scrive una **rilevazione** in `.mde-code/_findings/`, con le forme e i numeri, senza nomi del tuo codice |
| una **descrizione** sbagliata | la corregge con `code_set_description`, come nella [prova 4](04-analizza-il-codice.md) |

La rilevazione arriva a chi mantiene MdExplorer con **«Invia diagnostica»**, dalla lista dei progetti: spunta «Allega le
rilevazioni di MarkAgent», guarda l'anteprima e invia.

## Per approfondire

[Come Mark verifica il grafo](../guida/come-mark-verifica-il-grafo.md): il TBox, le regole, i pacchetti di linguaggio con
il loro TBox, le rilevazioni.

[Torna alla sezione](../README.md)
