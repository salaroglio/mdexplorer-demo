---
title: "Prova 4: fai analizzare il codice"
---

# Prova 4: fai analizzare il codice

## TL;DR

Il grafo sa *chi chiama chi*, non *a che cosa serve*. «Analizza il codice con Mark» fa leggere a Mark ogni sorgente e
gli fa scrivere a che cosa serve il file e, per ogni simbolo, una descrizione con il significato dei parametri e del
valore restituito. Le descrizioni finiscono nel grafo: da lì si cerca **per significato**, e se una non va bene la fai
correggere a Mark parlandogli.

- Un pulsante nella finestra «Ambiente di sviluppo»; un paio di minuti per quindici file, una chiamata AI per file.
- Mark analizza solo ciò che non ha descrizione o ha cambiato firma: la seconda volta non fa niente.
- Le righe che non rispettano lo schema vengono **scartate e contate**; una correzione di Mark passa dagli stessi controlli.

## Cosa fare

1. Tasto destro su `esempio` → **«Ambiente di sviluppo…»**. Nella finestra c'è **«Analizza il codice con Mark»**.
   (Attenzione al nome: **«Analizza il codice»**, senza «con Mark», è l'altra azione: rilegge il codice e rifà il grafo
   dei fatti, senza AI.)
2. Premilo. La finestra scrive **«Mark sta analizzando il codice…»**, il motore scelto per il progetto e poi, file per
   file, quanti simboli ha da analizzare e quanti ne ha analizzati:

   ```text
   Motore Claude Code (sonnet), 15 file da guardare
   1/15 grafo-del-codice/esempio/Assistente/IMotoreRisposte.cs: 2 simboli da analizzare
   grafo-del-codice/esempio/Assistente/IMotoreRisposte.cs: 3 analizzati, 0 righe scartate
   …
   ```

   I simboli da analizzare sono 2, gli analizzati 3: il terzo è il file stesso, a che cosa serve.
3. Aspetta la riga finale: **«Analisi con Mark completata: 71 simboli in 15 file (0 righe scartate)»**. Sono 56 simboli e
   15 file.

   ![La finestra alla fine: analisi con Mark completata, 71 simboli in 15 file, 0 righe scartate](assets/schermate/analisi-con-mark.png)

4. Apri il grafo e premi **«Utilità dei file»**: sotto ogni file c'è ora una frase che dice a che cosa serve. Un clic su
   un metodo mostra la sua descrizione nella scheda.

## Se una riga viene scartata

MdExplorer non si fida dell'AI sulla forma: una riga con un campo che lo schema non prevede, o un parametro che il metodo
non ha, viene **buttata e contata**, mai corretta o indovinata. Il simbolo resta «senza descrizione» nel report. Nel
nostro giro di oggi non ne è stata scartata nessuna; se ti capita, premi di nuovo «Analizza il codice con Mark»:
stavolta Mark guarda solo i simboli che mancano. Per un simbolo solo c'è il tasto destro sul grafo, **«Analizza con
Mark»** o **«Rifai l'analisi con Mark»**; per un file, **«Rifai l'analisi del file con Mark»**.

## Dove sono finite

Apri la scheda «Differenze»: accanto a ogni `.ast.ttl` c'è ora un **`.doc.ttl`**. Aprine uno, per esempio
`.mde-code/grafo-del-codice/esempio/Metriche/MetricheRisoluzione.cs.doc.ttl`:

```turtle
<urn:mde:doc:5230841d386d6f2035b5db10> a code:Description ;
    code:describes <urn:mde:sym:5230841d386d6f2035b5db10> ;
    code:summary "Calcola la quota di ticket chiusi al primo contatto sul totale dei ticket gestiti, cioè risolti più scalati. Non modifica lo stato." ;
    code:returnsDescription "Un numero tra 0 e 1: i ticket risolti al primo contatto divisi per risolti più scalati. Torna 0 se non è stato ancora registrato nessun ticket, senza sollevare eccezioni." ;
    code:writtenBy "mde-code-doc 5 / Claude Code (sonnet)" ;
    code:signatureHash "d70c1a02…" .
```

Ogni descrizione dice **chi l'ha scritta** (la versione delle istruzioni e il motore) e porta l'**impronta della firma**
al momento della scrittura: se un domani il metodo cambia parametri, il report la segnala tra le «descrizioni da
rivedere» e la prossima analisi la riscrive. Se cambia solo il corpo, la descrizione resta. A che cosa serve il file sta
in una voce a parte, `code:FileDescription`, nello stesso script.

## Cercare per significato

Torna al tab «Mark Agent» e chiedi:

> Quale metodo calcola la quota di ticket chiusi al primo contatto? Cerca per significato nel grafo e dimmi cosa dice la descrizione.

Nessuna di quelle parole è nel nome del metodo. Mark lo trova lo stesso, `MetricheRisoluzione.TassoPrimoContatto()`,
perché la ricerca a testo pieno del grafo ora indicizza anche le descrizioni; e riporta la sintesi, il valore restituito
(«un numero tra 0 e 1… torna 0 se non è stato ancora registrato nessun ticket») e chi l'ha scritta. Poi chiude il
cerchio con la domanda della prova 3: *ora ho la formula: alzando la soglia salgono gli scalati e scendono i risolti, il
tasso cala.*

## Fai correggere una descrizione

Le descrizioni non sono scolpite. Nella [prova 3](03-chiedi-a-mark.md) Mark ha trovato un punto delicato di `Gestisci`:
il ticket viene archiviato prima di chiedere la proposta. La descrizione scritta dall'analisi non lo dice. Chiedi a Mark,
nella sua finestra o nel tab:

> Aggiungi alla descrizione di Gestisci nel grafo, come avvertenza, il punto delicato che hai trovato sul ticket archiviato prima della proposta. Non toccare il resto.

![Mark conferma la correzione: l'avvertenza aggiunta, il resto invariato](assets/schermate/mark-corregge.png)

Mark usa lo strumento `code_set_description`, l'unico del grafo che scrive. Non apre lo script e non lo scrive lui:
chiede a MdExplorer di aggiornare la descrizione, e MdExplorer controlla la richiesta come controlla l'analisi. Un
parametro che il metodo non ha viene rifiutato con l'elenco di quelli veri; una descrizione scritta per una firma vecchia
non si ritocca senza riscriverla tutta. Poi aggiorna lo script `.doc.ttl` e il grafo, con l'impronta della firma di oggi:
la prossima «Analizza il codice con Mark» non la riscrive.

Nel nostro giro, in `ServizioAssistente.cs.doc.ttl` le note di `Gestisci` finiscono così:

> … **Avvertenza:** il ticket è archiviato prima di chiedere la proposta al motore. Se Proponi solleva un'eccezione (per
> esempio il motore a parole chiave con testo nullo), il ticket resta nell'archivio senza una proposta, senza il
> passaggio a InAttesaDiConferma e senza scalo al secondo livello.

Un limite da sapere: lo script ricorda **un solo autore**, l'ultimo che l'ha toccato. Dopo la correzione tutte le
descrizioni di `ServizioAssistente.cs` dicono `writtenBy "code_set_description"`, anche quelle che Mark non ha cambiato.
Chi le ha scritte davvero lo dice la cronologia di Git ([prova 5](05-il-grafo-va-su-git.md)).

## Quanto costa e quando rifarlo

- Una chiamata AI per file con qualcosa da analizzare. Per quindici file, pochi centesimi; per un progetto di mille file,
  una scelta da fare con calma, cartella per cartella.
- Si rifà quando il report mostra simboli senza descrizione o da rivedere. L'analisi con Mark non tocca mai ciò che è già
  descritto e non ha cambiato firma; dal tasto destro sul grafo si rifà un simbolo o un file anche se descritto.
- Una correzione con `code_set_description` non chiama nessuna AI in più: il testo lo scrive Mark nella conversazione.
- Le descrizioni vanno su Git con gli script: le scrive uno, le leggono tutti ([prova 5](05-il-grafo-va-su-git.md)).

[← Prova 3](03-chiedi-a-mark.md) · [Prova 5: il grafo va su Git →](05-il-grafo-va-su-git.md) · [Torna alla sezione](../README.md)
