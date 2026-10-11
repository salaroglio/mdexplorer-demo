---
title: "Prova 4: fai scrivere le descrizioni"
---

# Prova 4: fai scrivere le descrizioni

## TL;DR

Il grafo sa *chi chiama chi*, non *a che cosa serve*. «Descrivi il codice con Mark» fa leggere a Mark ogni sorgente e
gli fa scrivere, per ogni simbolo, una descrizione e il significato dei parametri. Le descrizioni finiscono nel grafo,
e da quel momento si può cercare **per significato**.

- Un pulsante nella finestra «Ambiente di sviluppo»; due o tre minuti per quindici file, una chiamata AI per file.
- Mark descrive solo chi non ha descrizione o ha cambiato firma: la seconda volta non fa niente.
- Le righe che non rispettano lo schema vengono **scartate e contate**: il programma non si fida dell'AI sulla forma.

## Cosa fare

1. Tasto destro su `esempio` → **«Ambiente di sviluppo…»**. Nella finestra c'è **«Descrivi il codice con Mark»**.
2. Premilo. La finestra mostra il motore scelto per il progetto e poi, file per file, quanti simboli ha da descrivere
   e quanti ne ha descritti:

   > Motore Claude Code (sonnet), 15 file da guardare
   > 1/15 grafo-del-codice/esempio/Assistente/IMotoreRisposte.cs: 2 simboli da descrivere
   > grafo-del-codice/esempio/Assistente/IMotoreRisposte.cs: 2 descritti, 0 righe scartate
   > …

3. Aspetta la riga finale: **«Descrizioni scritte: 55 simboli in 15 file (1 righe scartate)»**.

   ![La finestra alla fine: descrizioni scritte, 55 simboli in 15 file](assets/schermate/descrizioni-scritte.png)

## Quella riga scartata

Nel nostro giro Mark ha scritto, per la classe `ServizioAssistente`, una riga con un campo che lo schema non prevede.
MdExplorer **non la corregge e non la indovina**: la butta, la conta, e nel report la classe resta «senza descrizione».
Premi di nuovo «Descrivi il codice con Mark»: stavolta Mark guarda un solo simbolo, quello che manca, e la riga
arriva giusta. È lo stesso principio di tutto il grafo: ciò che entra deve avere la forma giusta, e ogni fatto dice chi
lo ha scritto (`writtenBy: mde-code-doc 1 / Claude Code (sonnet)`).

## Dove sono finite

Apri la scheda «Differenze»: accanto a ogni `.ast.jsonl` c'è ora un **`.doc.jsonl`**. Aprine uno, per esempio
`.mde-code/grafo-del-codice/esempio/Metriche/MetricheRisoluzione.cs.doc.jsonl`:

```json
{"type":"symbolDoc","symbolId":"85a621fce7e3b47d3910e326","summary":"Tiene i contatori delle metriche di risoluzione dell'help desk: ticket risolti, risolti al primo contatto e scalati al secondo livello. Serve a calcolare i numeri che guarda il comitato…","signatureHash":"181c52be…"}
```

Il `signatureHash` è l'impronta della firma al momento della descrizione: se un domani il metodo cambia parametri,
il report lo segnala tra le «descrizioni da rivedere» e il prossimo «Descrivi» lo riscrive. Se cambia solo il corpo,
la descrizione resta.

## Cercare per significato

Torna al tab «Mark Agent» e chiedi:

> Quale metodo calcola la quota di ticket chiusi al primo contatto? Cerca per significato nel grafo e dimmi cosa dice la descrizione.

Nessuna di quelle parole è nel nome del metodo. Mark lo trova lo stesso, `MetricheRisoluzione.TassoPrimoContatto()`,
righe 28-32, perché la ricerca a testo pieno del grafo ora indicizza anche le descrizioni; e riporta la sintesi, il
valore restituito («un numero tra 0 e 1, i risolti al primo contatto divisi per risolti più scalati, zero se non c'è
ancora niente») e chi l'ha scritta. Poi chiude il cerchio con la domanda della prova 3: *ora ho la formula: alzando la
soglia salgono gli scalati e scendono i risolti, il tasso cala.*

## Quanto costa e quando rifarlo

- Una chiamata AI per file con simboli da descrivere. Per quindici file, pochi centesimi; per un progetto di mille file,
  una scelta da fare con calma, cartella per cartella.
- Si rifà quando il report mostra simboli senza descrizione o da rivedere. «Descrivi» non tocca mai ciò che è già
  descritto e non ha cambiato firma; con `force` (dalla API) si riscrive tutto.
- Le descrizioni vanno su Git con gli script: le scrive uno, le leggono tutti ([prova 5](05-il-grafo-va-su-git.md)).

[← Prova 3](03-chiedi-a-mark.md) · [Prova 5: il grafo va su Git →](05-il-grafo-va-su-git.md) · [Torna alla sezione](../README.md)
